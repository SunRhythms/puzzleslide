using CoreGraphics;
using Foundation;
using System;
using UIKit;
using EventKitUI;

namespace puzzleslide
{
    public partial class ViewController : UIViewController
    {
        #region vars
        float gameViewWidth;
        float tileWidth;



       #endregion



        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            gameView.LayoutIfNeeded();
            gameViewWidth = (float)gameView.Frame.Size.Width;
            makeTiles();

        }

        private void makeTiles()
        {


            tileWidth = gameViewWidth / 4;
            float xCen = tileWidth / 2;
            float yCen = tileWidth / 2;
            int counter = 1;


            for (int h = 0; h < 4; h++)
            {

                for (int i = 0; i < 4; i++)
                {
                    UILabel textTile = new UILabel();
                    CGRect tileFrame = new CGRect(0, 0, tileWidth - 10, tileWidth - 10);

                    textTile.Frame = tileFrame;



                    CGPoint tileCen = new CGPoint(xCen, yCen);
                    textTile.Center = tileCen;

                    textTile.BackgroundColor = UIColor.Green;

                    textTile.Text = counter.ToString();


                    textTile.TextAlignment = UITextAlignment.Center;

                    textTile.Font = UIFont.SystemFontOfSize(25);

                    gameView.AddSubview(textTile);

                    xCen += tileWidth;
                    counter = counter + 1;
                }

                xCen = tileWidth / 2;
                yCen += tileWidth;

            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
