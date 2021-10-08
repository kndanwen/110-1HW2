using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW2
{
    public partial class StuScore : System.Web.UI.Page
    {
        public class Scores
        {
            public string s_Id;
            public float f_ChiS;
            public float f_MathS;
            public float f_EngS;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Scores o_Scores = new Scores();
            o_Scores.s_Id = "A123456789";
            o_Scores.f_ChiS = 62f;
            o_Scores.f_MathS = 73f;
            o_Scores.f_EngS = 84f;

            Response.Write("s_Id=" + o_Scores.s_Id +
                "," + "f_ChiS=" + o_Scores.f_ChiS.ToString() +
                "," + "f_MathS=" + o_Scores.f_MathS.ToString() +
                "," + "f_EngS=" + o_Scores.f_EngS.ToString());
        
        }
    }
}