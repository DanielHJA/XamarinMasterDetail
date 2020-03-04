using System;
using MasterDetailLearning.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(TabletDefaultMasterDetailRenderer_ios))]
namespace MasterDetailLearning.iOS
{
    public class TabletDefaultMasterDetailRenderer_ios: TabletMasterDetailRenderer
    {
        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            if (Element is MasterDetailPage item)
            {
                var master = NativeView.Subviews[0];

                if (item.IsPresented)
                {
                    master.AccessibilityElementsHidden = false;
                }
                else
                {
                    master.AccessibilityElementsHidden = true;
                }

                NativeView.SetNeedsFocusUpdate();
            }
        }
    }
}
