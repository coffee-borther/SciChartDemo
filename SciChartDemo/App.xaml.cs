using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using SciChart.Charting.Visuals;

namespace SciChartDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            SciChartSurface.SetRuntimeLicenseKey(
                "PdY3/28MznCSvqkyId3cklrcQ4lqfgaon4Kxymyvt/b92VkxLcLQG1sHn3tTYPqRVfp6uu1s9ZthUl6DwJEwD7ym2Zh7bEcXlRk7TgGzXnaQ7ji91eXrFg9OYdfk77I9TH8Uap2oEIHLL54t+ZIRiMTvOb/91ayIVPvhiGHOovteOjoDr/KPkXU7suJRK/P2VDXh0sHcL50S+fA2/UIZye6KqqyVAtvIXQ2el8zhKxiSw1zTUcZzv0eekK+PxTF4nRtSi7jXnaPsTIiCOLxR8Gl8TcRm9mrkxsFktZ0D0Fl6reDhogEcAcImPzN4+hWgODA8hLYZRvI0UsAXO8sysgJBUsA7SD6FTtygS9YvD8qr5k5K4nL7Hh0N4zgNLKBKy8GKOJ0BQxIFwsP3DmlhFXg3DKXpBS4LNFlvfJOvVmBDYMrDdRQqosAlxxLn0KZ7BGs5X1n/Gi3sygxV8YRjS0m7T5pVEVzQlzPzcwwzFe4AN5NhRHHgEyxJdMW/zurw4rLOprMtXMUYaHsdt9P8vKyyXmxs/uWBsLUry0uK2wtZqxV87OXDYXewTbXBnM1TAg==");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}