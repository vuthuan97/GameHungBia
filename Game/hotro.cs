using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Game
{
    public static class hotro
    {
        public static int speed = 8;
        public static int speednguoi=10;
       public static String cottruyen = "Vào một ngày đẹp trời ,G đang thực hiện công việc hàng ngày của mình là vận chuyển bia từ nhà máy sản xuất tới các đại lý trong vùng.Nhưng đó không phải là ngày đẹp" +
            " trời đối với G.Xe của G đã bị lật do bánh xe đè lên tảng đá lớn, thế là số bia trong thùng xe đã bay lên không trung.Điều chắc chắn rằng số bia đó sẽ văng ra đường, " +
            "số bia đó bị vỡ, G phải đền bù cho công ty,vốn dĩ G đã ở trong một gia đình khó khăn, điều này khiến G càng khó xử hơn.Vậy nên các bạn hãy giúp G bằng cách hứng được thật nhiều bia để giúp G nhé!";
        public static void anbia(PictureBox b1,PictureBox b2,PictureBox b3,PictureBox b4)
        {
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
        }
        public static PictureBox displayPic(PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4)//ham hien thi anh
        {
            pic1.Visible = true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            return pic1;
        }
        public static int tocdodichuyen(int score,int tocdo)
        {
             speednguoi = 10;
            if (score == 10) speednguoi = 12;
            if (score == 15) speednguoi = 15;
            if (score == 20) speednguoi = 17;
            if (score == 30) speednguoi = 19;
            return speednguoi;
        }
        public static int tangtocdo(int score,int speed)
        {
            if (score == 10) speed = 12;
            if (score == 15) speed = 15;
            if (score == 20) speed = 17;
            if (score == 30) speed = 19;
            return speed;

        }
        public static PictureBox picbiavo(int x)
        {
            PictureBox pic = new PictureBox();
            pic.Height = 30; pic.Width = 50;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new System.Drawing.Point(x,637);
            pic.Image = Properties.Resources.vỡ_beer2;
            pic.Tag = "biavo";
            return pic;
        }
    }
}
