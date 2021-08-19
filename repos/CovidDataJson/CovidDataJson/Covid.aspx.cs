using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.UI.WebControls;

namespace covid19
{
    public partial class Covid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            var list = CreateObject();
            grid1.DataSource = list.OrderByDescending(x => x.confirmed).Take(10).ToList();
            grid1.DataBind();

//            covidChart.DataSource = list.OrderByDescending(x => x.confirmed).Take(10).Select(x => x.confirmed).ToList();
//            covidChart.DataBind();

        }

        private List<Covids> CreateObject()
        {
            string URL = "https://pomber.github.io/covid19/timeseries.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.ContentType = "application/json";

            List<Covids> Ulkeler = new List<Covids>();
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();

                var objects = Object.Parse(response); // parse as array  
                foreach (var obj in objects.Properties())
                {
                    //son güne git
                    var obj2 = obj.Value.Last;
                    var covids = new Covids()
                    {
                        Name = obj.Name,
                        date = (DateTime)obj2["date"],
                        confirmed = (int)obj2["confirmed"],
                        deaths = (int)obj2["deaths"],
                        recovered = (int)obj2["recovered"]
                    };
                    Ulkeler.Add(covids);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ulkeler;
        }
        protected override void OnInit(EventArgs e)
        {
            grid1.RowDataBound += grid1_RowDataBound;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var list = CreateObject();
            grid1.DataSource = list.OrderByDescending(x => x.confirmed).Take(10).ToList();
            grid1.DataBind();
        }

        protected void grid1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                TableCell cell = e.Row.Cells[0];
                string quantity = cell.Text;
                if (quantity == "Turkey")
                {
                    cell.BackColor = Color.Red;
                }


                //var grid2 = (GridView)e.Row.FindControl("grid2");
                //TableCell cell = e.Row.Cells[1];
                //var Name = cell.Text;
                //grid2.DataSource = Ulkeler.Where(w => w.Name == e.Row.Cells[1].Text);
                //grid2.DataBind();
            }
        }
    }

    public class Covids
    {
        public string Name { get; set; }
        public DateTime date { get; set; }
        public int confirmed { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }

    }
}