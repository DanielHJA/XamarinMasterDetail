using System;
using MasterDetailLearning.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(PhoneDefaultMasterDetailRenderer_ios))]
namespace MasterDetailLearning.iOS
{
    public class PhoneDefaultMasterDetailRenderer_ios : PhoneMasterDetailRenderer
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
