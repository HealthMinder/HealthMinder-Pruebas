using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMinderSorM.Views.Aplication
{
    public class HomeShellPageFlyoutMenuItem
    {
        public HomeShellPageFlyoutMenuItem()
        {
            TargetType = typeof(HomeShellPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public HomeShellPageFlyoutMenuItem(string title, Type targetType)
        {
            Title = title;
            TargetType = targetType;
        }

    }
}