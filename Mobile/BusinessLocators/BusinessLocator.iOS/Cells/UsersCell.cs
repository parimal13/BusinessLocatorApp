using Foundation;
using System;
using UIKit;
using BusinessLocator.iOS.Model;
using CoreAnimation;
using BusinessLocator.Shared.Models;
using System.IO;

namespace BusinessLocator.iOS
{
    public partial class UsersCell : UITableViewCell
    {
        private NSString cellID;

        public UsersCell(IntPtr handle) : base (handle)
        {
        }

        public UsersCell(NSString cellID) : base(UITableViewCellStyle.Default, cellID)
        {
            this.cellID = cellID;
        }

        public void UpdateCell(UserProfileModel data)
        {
            //Base64 to  Image Conversion
            //var base64String = "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";
            var imageBytes = Convert.FromBase64String(data.Image);
            var imageData = NSData.FromArray(imageBytes);
            var Image = UIImage.LoadFromData(imageData);

            //Dispaly image From URL
            //var url = NSUrl.FromString("https://us.v-cdn.net/5019960/uploads/userpics/863/nH3M1EPC2YZE5.jpg");
            //var imgdata = NSData.FromUrl(url);
            //var uiImage = UIImage.LoadFromData(imgdata);

            ProfileImage.Image = Image;
            lblName.Text = data.DisplayName;
            lblMobileNumber.Text = data.PhoneNumber;
            lblAddress.Text = data.Address1;
        }

        public override void LayoutSubviews()
        {
            CALayer profileImageCircle = ProfileImage.Layer;
            profileImageCircle.CornerRadius = 35;
            profileImageCircle.MasksToBounds = true;
            //profileImageCircle.BorderColor = UIColor.FromRGB(98, 107, 186).CGColor;
            //profileImageCircle.BorderWidth = 3;
        }
    }
}