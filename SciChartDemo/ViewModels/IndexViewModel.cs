using Prism.Commands;
using Prism.Mvvm;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.RenderableSeries;
using System;
using System.IO;

namespace SciChartDemo.ViewModels
{
    public class IndexViewModel: BindableBase
    {

        private readonly string dataFilePath = @"C:\Users\PYF\Desktop\白水泥50微秒256.1.pea";
        private IDataSeries<double, double> amplitudeDataSeries;
        private IDataSeries<double, double> realDataSeries;
        private IDataSeries<double, double> imagDataSeries;
        public IndexViewModel()
        {
            Chart = new SciChartSurface();
        }
        private SciChartSurface chart;
        public SciChartSurface Chart
        {
            get { return chart; }
            set { SetProperty(ref chart, value); }
        }

        public DelegateCommand LoadDataCommand => new DelegateCommand(LoadData);

        private void LoadData()
        {
            var lines = File.ReadAllLines(dataFilePath);

            amplitudeDataSeries = new XyDataSeries<double, double>();
            realDataSeries = new XyDataSeries<double, double>();
            imagDataSeries = new XyDataSeries<double, double>();

            for (int i = 4; i < lines.Length; i++)
            {
                var line = System.Text.RegularExpressions.Regex.Split(lines[i], @"\s+");
                double time = Convert.ToDouble(line[0]);
                double amplitude = Convert.ToDouble(line[1]);
                double real = Convert.ToDouble(line[2]);
                double imag = Convert.ToDouble(line[3]);

                amplitudeDataSeries.Append(time, amplitude);
                realDataSeries.Append(time, real);
                imagDataSeries.Append(time, imag);
            }

            var xAxis = new NumericAxis();
            var yAxis = new NumericAxis();

            var amplitudeRenderableSeries = new FastLineRenderableSeries { DataSeries = amplitudeDataSeries };
            var realRenderableSeries = new FastLineRenderableSeries { DataSeries = realDataSeries };
            var imagRenderableSeries = new FastLineRenderableSeries { DataSeries = imagDataSeries };

            Chart.XAxes.Add(xAxis);
            Chart.YAxes.Add(yAxis);
            Chart.RenderableSeries.Add(amplitudeRenderableSeries);
            Chart.RenderableSeries.Add(realRenderableSeries);
            Chart.RenderableSeries.Add(imagRenderableSeries);
        }
    }
}
