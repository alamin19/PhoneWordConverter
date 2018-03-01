using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;
using PhoneWordConverter.iOS;

[assembly: Dependency(typeof(PhoneDialer))]

namespace PhoneWordConverter.iOS
{
    public class PhoneDialer : IDailer
    {
        public Task<bool> DialAsync(string number)
        {
            return Task.FromResult(
                UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number))
            );
        }
    }
}
