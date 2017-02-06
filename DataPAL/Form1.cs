using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.SystemUI;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.GeoprocessingUI;
using ESRI.ArcGIS.Display;
using System.Windows;
using System.Windows.Input;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using ESRI.ArcGIS.Editor;

namespace DataPAL
{
    public partial class Form1 : Form
    {

        // 'Globals'
        List<object> layerPaths = new List<object>();
        List<string> searchSource = new List<string>();
   
        // Initialize Form1
        public Form1()
        {
            InitializeComponent();
            radioButtonImg.Checked = true;
            radioButtonWtr.Checked = true;
            radioButtonTrns.Checked = true;
            radioButtonEM.Checked = true;
            radioButtonBound.Checked = true;
        }

        // Gets layer list to populate Check Box
        private void PopulatecheckedListBox1(CheckedListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                layerPaths.Add(file.FullName);
                string fileName = Path.GetFileNameWithoutExtension(file.FullName);
                lsb.Items.Add(fileName);
            }
        }

        // Sets behavior for 'Group Box 1'
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
        }

        // OnChange event for 'Boundaries' radio button
        private void radioButtonBound_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\Boundaries", "*.lyr");
            
        }

        // OnChange event for 'Imagery' radio button
        private void radioButtonImg_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\Imagery", "*.lyr");
        }

        // OnChange event for 'Water' radio button
        private void radioButtonWtr_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\Water", "*.lyr");
        }

        // OnChange event 'Transportation' radio button
        private void radioButtonTrns_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\Transportation", "*.lyr");
        }

        // OnChange event for 'Environmental Monitoring' radio button
        private void radioButtonEM_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\HabitatEnvironment", "*.lyr");
        }

        // Set behavior for 'Group Box 2'
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
        }

        // OnChange event 'Air Managment' radio button
        private void radioButtonAirM_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\AirDiv", "*.lyr");
        }

        // OnChange event 'Waste Managment' radio button
        private void radioButtonWstM_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\WasteDiv", "*.lyr");
        }

        // OnChange event for 'Wetland Managment' radio button
        private void radioButtonWetM_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\WetlandsDiv", "*.lyr");
        }

        // OnChange event for 'Water Managment' radio button
        private void radioButtonWtrM_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            PopulatecheckedListBox1(checkedListBox1, @"\\Epcnas\gis\DataPal\Layers\WaterDiv", "*.lyr");
        }
        
        // Sets behavior for 'Checked List Box'
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (checkedListBox1.SelectedIndex >= 0)
            {
                toolStrip1.Enabled = true;
            }
            else
            {
                toolStrip1.Enabled = false;
            }
        }

        // Toolstrip1 Renderer
        public class TestStripRenderer : ToolStripSystemRenderer
        {
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
            }
        }

        // OnClick Event for 'Meta Data' button
        private void metaDataButton_Click(object sender, EventArgs e)
        {
            IGxLayer gxLayer = new GxLayerClass();
            IGxFile gxFile = gxLayer as IGxFile;
            string sLayerName = (string)checkedListBox1.SelectedItem;
            var stringList = layerPaths.ConvertAll(x => Convert.ToString(x));
            List<string> paths = new List<string>();
            foreach (string item in stringList)
            {
                if (item.Contains(sLayerName))
                    gxFile.Path = @item;
            }
            paths.Add(gxFile.Path);
            paths.Add(sLayerName);            
            ILayer layer = gxLayer.Layer as ILayer;
            IDataset pDataSet = (IDataset)layer;
            IName pName = (IName)pDataSet.FullName;
            IFeatureClassName pFeatureClassName = (IFeatureClassName)pName;
            IMetadata pMetadata = (IMetadata)pFeatureClassName;
            IMetadataViewWindow2 pMetadataViewWindow = new MetadataViewWindowClass();
            pMetadataViewWindow.Application = ArcMap.Application;
            pMetadataViewWindow.Layer = layer;
            pMetadataViewWindow.Metadata_2 = pMetadata.Metadata;
            pMetadataViewWindow.Show(true);
        }

        // OnClick Event for 'addLayer' button
        private void okButton_Click(object sender, EventArgs e)
        {
            IMxDocument mxdoc = ArcMap.Application.Document as IMxDocument;
            List<string> chkdLayers = new List<string>();
            var stringList = layerPaths.ConvertAll(x => Convert.ToString(x));
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                foreach (string item in stringList)
                {
                    if (item.Contains(itemChecked.ToString()))
                        chkdLayers.Add(@item);
                }

            }

            List<string> addLayers = chkdLayers.Distinct().ToList();
            foreach (string lyr in addLayers)
            {
                IGxLayer gxLayer = new GxLayerClass();
                IGxFile gxFile = gxLayer as IGxFile;
                gxFile.Path = @lyr;
                ILayer layer = gxLayer.Layer as ILayer;
                IMap map = mxdoc.FocusMap;
                map.AddLayer(layer);
            }
            mxdoc.ActivatedView.Refresh();
            mxdoc.UpdateContents();
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);

            }

        }

        // OnClick Event for 'Clear' button
        private void clearButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
            checkedListBox1.Items.Remove(textBox1.Text);
            textBox1.Clear();
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // OnClick Event for 'Attribute Table' button
        private void showAttributesButton_Click(object sender, EventArgs e)
        {
            ITableWindow3 tableWindow = new TableWindowClass();
            IFeatureLayer fLyr = new FeatureLayerClass();
            IGxLayer gxLayer = new GxLayerClass();
            IGxFile gxFile = gxLayer as IGxFile;
            string sLayerName = (string)checkedListBox1.SelectedItem;
            var stringList = layerPaths.ConvertAll(x => Convert.ToString(x));
            List<string> paths = new List<string>();
            foreach (string item in stringList)
            {
                if (item.Contains(sLayerName))
                    gxFile.Path = @item;
            }
            ILayer layer = gxLayer.Layer as ILayer;
            tableWindow.Layer = layer;
            tableWindow.Application = ArcMap.Application;
            tableWindow.Show(true);
            
        }

        // OnClick Event for 'Search' button
        private void button1_Click(object sender, EventArgs e)
        {
            //groupBox1.Enabled = true;
            if (checkedListBox1.Items.Contains(textBox1.Text))
            {
                checkedListBox1.Items.Remove(textBox1.Text);
                checkedListBox1.Items.Insert(0, textBox1.Text);
                checkedListBox1.SelectedIndex = 0;
            }
            else
            {
                checkedListBox1.Items.Insert(0, textBox1.Text);
                checkedListBox1.SelectedIndex = 0;
            }
            
        }

        // Allows for 'Tool Tips'
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        

     
    }
}
