using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataPAL
{
    public class Button1 : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Button1()
        {
        }

        protected override void OnClick()
        {
            //Launches form
            DataPAL.Form1 frm = new Form1();
            frm.Show();
            ArcMap.Application.CurrentTool = null;

        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
