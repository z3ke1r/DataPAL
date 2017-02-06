namespace DataPAL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEM = new System.Windows.Forms.RadioButton();
            this.radioButtonTrns = new System.Windows.Forms.RadioButton();
            this.radioButtonWtr = new System.Windows.Forms.RadioButton();
            this.radioButtonImg = new System.Windows.Forms.RadioButton();
            this.radioButtonBound = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonWetM = new System.Windows.Forms.RadioButton();
            this.radioButtonWtrM = new System.Windows.Forms.RadioButton();
            this.radioButtonWstM = new System.Windows.Forms.RadioButton();
            this.radioButtonAirM = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.metaDataButton = new System.Windows.Forms.ToolStripButton();
            this.showAttributesButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.okButton = new System.Windows.Forms.ToolStripButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonEM);
            this.groupBox1.Controls.Add(this.radioButtonTrns);
            this.groupBox1.Controls.Add(this.radioButtonWtr);
            this.groupBox1.Controls.Add(this.radioButtonImg);
            this.groupBox1.Controls.Add(this.radioButtonBound);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonEM
            // 
            this.radioButtonEM.AutoSize = true;
            this.radioButtonEM.Location = new System.Drawing.Point(126, 43);
            this.radioButtonEM.Name = "radioButtonEM";
            this.radioButtonEM.Size = new System.Drawing.Size(151, 17);
            this.radioButtonEM.TabIndex = 4;
            this.radioButtonEM.TabStop = true;
            this.radioButtonEM.Text = "Habitat && Environment";
            this.radioButtonEM.UseVisualStyleBackColor = true;
            this.radioButtonEM.CheckedChanged += new System.EventHandler(this.radioButtonEM_CheckedChanged);
            // 
            // radioButtonTrns
            // 
            this.radioButtonTrns.AutoSize = true;
            this.radioButtonTrns.Location = new System.Drawing.Point(7, 44);
            this.radioButtonTrns.Name = "radioButtonTrns";
            this.radioButtonTrns.Size = new System.Drawing.Size(107, 17);
            this.radioButtonTrns.TabIndex = 3;
            this.radioButtonTrns.TabStop = true;
            this.radioButtonTrns.Text = "Transportation";
            this.radioButtonTrns.UseVisualStyleBackColor = true;
            this.radioButtonTrns.CheckedChanged += new System.EventHandler(this.radioButtonTrns_CheckedChanged);
            // 
            // radioButtonWtr
            // 
            this.radioButtonWtr.AutoSize = true;
            this.radioButtonWtr.Location = new System.Drawing.Point(235, 20);
            this.radioButtonWtr.Name = "radioButtonWtr";
            this.radioButtonWtr.Size = new System.Drawing.Size(59, 17);
            this.radioButtonWtr.TabIndex = 2;
            this.radioButtonWtr.TabStop = true;
            this.radioButtonWtr.Text = "Water";
            this.radioButtonWtr.UseVisualStyleBackColor = true;
            this.radioButtonWtr.CheckedChanged += new System.EventHandler(this.radioButtonWtr_CheckedChanged);
            // 
            // radioButtonImg
            // 
            this.radioButtonImg.AutoSize = true;
            this.radioButtonImg.Location = new System.Drawing.Point(126, 20);
            this.radioButtonImg.Name = "radioButtonImg";
            this.radioButtonImg.Size = new System.Drawing.Size(69, 17);
            this.radioButtonImg.TabIndex = 1;
            this.radioButtonImg.TabStop = true;
            this.radioButtonImg.Text = "Imagery";
            this.radioButtonImg.UseVisualStyleBackColor = true;
            this.radioButtonImg.CheckedChanged += new System.EventHandler(this.radioButtonImg_CheckedChanged);
            // 
            // radioButtonBound
            // 
            this.radioButtonBound.AutoSize = true;
            this.radioButtonBound.Location = new System.Drawing.Point(7, 20);
            this.radioButtonBound.Name = "radioButtonBound";
            this.radioButtonBound.Size = new System.Drawing.Size(92, 17);
            this.radioButtonBound.TabIndex = 0;
            this.radioButtonBound.TabStop = true;
            this.radioButtonBound.Text = "Boundaries ";
            this.radioButtonBound.UseVisualStyleBackColor = true;
            this.radioButtonBound.CheckedChanged += new System.EventHandler(this.radioButtonBound_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonWetM);
            this.groupBox2.Controls.Add(this.radioButtonWtrM);
            this.groupBox2.Controls.Add(this.radioButtonWstM);
            this.groupBox2.Controls.Add(this.radioButtonAirM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Division";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButtonWetM
            // 
            this.radioButtonWetM.AutoSize = true;
            this.radioButtonWetM.Location = new System.Drawing.Point(7, 44);
            this.radioButtonWetM.Name = "radioButtonWetM";
            this.radioButtonWetM.Size = new System.Drawing.Size(154, 17);
            this.radioButtonWetM.TabIndex = 4;
            this.radioButtonWetM.TabStop = true;
            this.radioButtonWetM.Text = "Wetlands Management";
            this.radioButtonWetM.UseVisualStyleBackColor = true;
            this.radioButtonWetM.CheckedChanged += new System.EventHandler(this.radioButtonWetM_CheckedChanged);
            // 
            // radioButtonWtrM
            // 
            this.radioButtonWtrM.AutoSize = true;
            this.radioButtonWtrM.Location = new System.Drawing.Point(167, 44);
            this.radioButtonWtrM.Name = "radioButtonWtrM";
            this.radioButtonWtrM.Size = new System.Drawing.Size(135, 17);
            this.radioButtonWtrM.TabIndex = 3;
            this.radioButtonWtrM.TabStop = true;
            this.radioButtonWtrM.Text = "Water Management";
            this.radioButtonWtrM.UseVisualStyleBackColor = true;
            this.radioButtonWtrM.CheckedChanged += new System.EventHandler(this.radioButtonWtrM_CheckedChanged);
            // 
            // radioButtonWstM
            // 
            this.radioButtonWstM.AutoSize = true;
            this.radioButtonWstM.Location = new System.Drawing.Point(167, 21);
            this.radioButtonWstM.Name = "radioButtonWstM";
            this.radioButtonWstM.Size = new System.Drawing.Size(137, 17);
            this.radioButtonWstM.TabIndex = 2;
            this.radioButtonWstM.TabStop = true;
            this.radioButtonWstM.Text = "Waste Management";
            this.radioButtonWstM.UseVisualStyleBackColor = true;
            this.radioButtonWstM.CheckedChanged += new System.EventHandler(this.radioButtonWstM_CheckedChanged);
            // 
            // radioButtonAirM
            // 
            this.radioButtonAirM.AutoSize = true;
            this.radioButtonAirM.Location = new System.Drawing.Point(7, 21);
            this.radioButtonAirM.Name = "radioButtonAirM";
            this.radioButtonAirM.Size = new System.Drawing.Size(116, 17);
            this.radioButtonAirM.TabIndex = 0;
            this.radioButtonAirM.TabStop = true;
            this.radioButtonAirM.Text = "Air Management";
            this.radioButtonAirM.UseVisualStyleBackColor = true;
            this.radioButtonAirM.CheckedChanged += new System.EventHandler(this.radioButtonAirM_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1938 IMAGERY HILLSBOROUGH",
            "1973 IMAGERY HILLSBOROUGH",
            "1984 IMAGERY HILLSBOROUGH CIR",
            "1994 IMAGERY HILLSBOROUGH CIR",
            "2004 IMAGERY HILLSBOROUGH",
            "2006 IMAGERY HILLSBOROUGH",
            "2008 IMAGERY HILLSBOROUGH",
            "2009 IMAGERY HILLSBOROUGH",
            "2010 IMAGERY HILLSBOROUGH",
            "2011 IMAGERY HILLSBOROUGH",
            "2012 IMAGERY HILLSBOROUGH",
            "2014 IMAGERY HILLSBOROUGH",
            "2016 IMAGERY HILLSBOROUGH",
            "2015 SWIM SEAGRASS IMAGERY",
            "AIRPORTS",
            "AL COUNTYSHORE AREAS",
            "ALT FUELS STATIONS",
            "AMBIENT AIR MONITORING SITES",
            "AMTRAK STATIONS 2008",
            "AREA CODES",
            "ARTIFICIAL REEFS",
            "BACKGROUND GROUNDWATER QUALITY",
            "BATHYMETRY",
            "BEACH ACCESS SITES",
            "BEACHES IS",
            "BIODIVERSITY HOT SPOTS RASTER",
            "BMMR IHN LMA 2012",
            "BMMR MANPHO BOUNDARIES 07",
            "BMMR MANPHO BOUNDARIES 09",
            "BMMR MANPHO BOUNDARIES 10",
            "BMMR MANPHO BOUNDARIES 11",
            "BMMR MANPHO BOUNDARIES 2005",
            "BMMR MANPHO DRG INDEX",
            "BMMR MANPHO REC UNITS 2005",
            "BMMR MANPHO REC UNITS 2009",
            "BMMR MANPHO REC UNITS 2010",
            "BMMR NONMAN REC PROG 2010",
            "BMMR OIL GAS PERMIT WELLS",
            "BOMR GYPSUMSTACKS",
            "BOMR GYPSUMSTACKS 2007",
            "BOMR GYPSUMSTACKS 2012",
            "BOMR IHN LMA 2006",
            "BOMR INTEGRATED HABT NETWK",
            "BOMR MANNON SITES",
            "BOMR MANNON SITES 2007",
            "BOMR MANNON SITES 2011",
            "BOMR MANPHO BOUNDARIES 1990",
            "BOMR MANPHO POST TOPO 2003",
            "BOMR MANPHO PRE TOPO 2003",
            "BOMR MINEABLE LIMIT",
            "BOMR NONMAN REC PROG",
            "BOMR NONMAN REC PROG 2007",
            "BOMR PARCELS REC STATUS",
            "BOMR POST LAND USE",
            "BOMR PRE LAND USE",
            "BOMR ZW PARCELS",
            "BOMR ZWPARCELS LANDCOVER 2003",
            "BOUNDARIES 24 AREAS",
            "BOUNDARIES 24 LINES",
            "BROWNFIELD AREAS",
            "BROWNFIELD SITES",
            "CLEAN MARINAS",
            "CLEAN WATER SPN SRF SP",
            "COAST GUARD ATON",
            "COASTAL CRIT EROSION AREAS",
            "COASTAL DEEPWATER PORTS",
            "COASTAL INLET MANAGEMENT",
            "COCKROACH BAY AQUATIC PRESERVE",
            "CONSERVATION EASEMENTS AREAS",
            "CONSERVATION EASEMENTS POINTS",
            "COUNTY BOUNDARY HILLSBOROUGH",
            "COUNTY BOUNDARY LEGAL",
            "COUNTY SEATS",
            "CULTURAL AND HISTORIC FEATURES",
            "CURRENT LANDUSE LDI LSI",
            "DACS BMP ENROLLMENT",
            "DIGITAL RASTER GRAPHICS 100",
            "DIGITAL RASTER GRAPHICS 250",
            "DOH BEACH SAMPLING LOCATIONS",
            "DOH SEWAGE TREATMENT DISPOSAL",
            "DOS HISTORIC BRIDGES",
            "DOS HISTORIC CEMETERIES",
            "DOS HISTORIC STRUCTURES",
            "DOS NATIONAL REGISTER SITES",
            "DOS RESOURCE GROUPS",
            "DRAINAGE BASINS 1997 AREAS",
            "DRAINAGE BASINS 1997 LINES",
            "DRAINAGE BASINS AREAS",
            "DRAINAGE BASINS LINES",
            "DRASTIC FLORIDAN AQUIFER",
            "DRASTIC INTERMEDIATE AQUIFER",
            "DRASTIC SURFICIAL AQUIFER",
            "DRG 24 TAMPA",
            "DWM WELL RESTRICTIONS",
            "ECOREGIONS",
            "ELEMENT OCCURRENCE",
            "ELEMENT OCCURRENCE AREAS",
            "EPA BROWNFIELDS PILOTS AREAS",
            "EPA PERMITTED DAMS",
            "EPA PRIORITY WETLANDS RASTER",
            "EPC TANK INSPECTIONS 2016",
            "EPC WQM DATA",
            "EPC WQM STATIONS",
            "ERP HISTORIC PERMITS",
            "ESSA PIPING PLOVER CH SP",
            "EXISTING TRAILS",
            "FAA OBSTRUCTIONS",
            "FAS RESPONSE",
            "FAS TOP",
            "FDOT BRIDGES",
            "FDOT COUNTY ROUTES",
            "FDOT DISTRICT BOUNDARIES",
            "FDOT HIGHWAY MILE MARKERS",
            "FDOT INTERSTATES",
            "FDOT LOCAL ROADS",
            "FDOT ROADS",
            "FDOT STATE ROUTES",
            "FDOT TOLL ROADS",
            "FDOT TRAFFIC METER LOCATIONS",
            "FDOT US ROUTES",
            "FEDERAL LANDS",
            "FEMA FLOOD ZONES",
            "FGS POTMAP",
            "FGS SPRINGS PROT AREAS",
            "FGS SUBSIDENCE INCIDENTS",
            "FGS SWALLETS",
            "FGS WELLS",
            "FIRE RESCUE SERVICES",
            "FIXED GUIDEWAY TRANSIT NETWORK",
            "FL CONSERVATION LANDS MA",
            "FL HOUSE DISTRICTS",
            "FL NATIONAL WILDLIFE REFUGES",
            "FL SENATE DISTRICTS",
            "FL SHORELINE AREAS",
            "FL SUBMERGED LANDS",
            "FLORIDA ADOPTED TMDLS",
            "FLORIDA BEACH NAMES",
            "FLORIDA COOP LAND COVER",
            "FLORIDA ENTERPRISE ZONES",
            "FLORIDA FOREVER ACQUISITIONS",
            "FLORIDA INVASIVE PLANTS 2008",
            "FLORIDA MANGROVES",
            "FLORIDA UTM ZONES",
            "FNAI AQUIFER RECHARGE",
            "FNAI CONSERVATION PRIORITIES",
            "FNAI ECOLOGICAL GREENWAYS",
            "FNAI FOREST LANDS TO MRF",
            "FNAI FRAGILE COASTAL RESOURCES",
            "FNAI FUNCTIONAL WETLANDS",
            "FNAI NATURAL FLOODPLAIN",
            "FNAI SIGNIF SURFACE WATERS",
            "FNAI SUSTAINABLE FORESTRY",
            "FNAI UNDER REP NAT COMM",
            "FRONT PORCH COMMUNITIES",
            "FUTURE LAND USE SOUTH",
            "FWC ANCHORAGES",
            "FWC BOAT RAMPS",
            "FWC EAGLE NESTS",
            "FWC ESI",
            "FWC OYSTER HABITATS",
            "FWC SHCA",
            "FWCC MANAGEMENT AREAS",
            "GA COUNTYSHORE AREAS",
            "GEODETIC CONTROL STATIONS",
            "GEOLOGY ENVIRONMENTAL",
            "GEOLOGY STRATIGRAPHY",
            "GNIS HISTORIC FEATURES",
            "GNIS NAMES",
            "GREEN LODGINGS",
            "GROUND WATER CONTAMINATION",
            "HABITAT IMAGERY",
            "HEAD DIFF",
            "HISTORIC HURRICANE PATHS",
            "HUC BASINS AREAS",
            "HUC BASINS LINES",
            "HYDROGRAPHIC FEATURES 2M AREAS",
            "HYDROGRAPHIC FEATURES 2M LINES",
            "IAS RESPONSE",
            "IAS THK",
            "IAS TOP",
            "ICR SITES CONTROL",
            "ICR SITES CONTROL1",
            "IMAGERY PINELLAS",
            "IMPAIRED WATERS 303D 1998",
            "INCORPORATED PLACES",
            "INCORPORATED PLACES 2000",
            "IWR STATIONS",
            "LAKE REGIONS",
            "LAKES AREAS",
            "LAKES POINTS",
            "LAND SURFACE ELEVATION 24",
            "LAND TRAIL OPPORTUNITIES",
            "LAND TRAIL PRIORITIES",
            "LANDSAT TM IMAGERY INDEX",
            "LAT LONG GRID INDEX",
            "MAJOR PRISONS 2006",
            "MAJOR RIVERS AREAS",
            "MAJOR RIVERS LINES",
            "MANATEE MORTALITY",
            "MANATEE PROTECTION ZONES",
            "MANATEE SYNOPTIC SURVEY",
            "MARINAS",
            "MARINE FACILITIES",
            "MARINE PROT AREAS",
            "MARINE TERRACES",
            "MILITARY BASES",
            "MISC TRANSPORTATION",
            "MITIGATION BANK SERVICE AREA",
            "MITIGATION BANKS",
            "MMP MANNON SITES 2014",
            "MMP MANNON SITES 2015",
            "MMP MANPHO BOUNDARIES 12",
            "MMP MANPHO BOUNDARIES 13",
            "MMP MANPHO REC UNITS 2011",
            "MMP MANPHO REC UNITS 2012",
            "MMP MANPHO REC UNITS 2013",
            "MMP OIL GAS PERMIT WELLS",
            "MMP OIL GAS PRE PERMIT WELLS",
            "MMP WMD CI BASIN",
            "MSHA MINING PTS",
            "NAIP IMAGERY 2010 FLIGHT DATES",
            "NAMED RIVERS LARGER STREAMS",
            "NATIONAL WTLDS INVENTORY AREAS",
            "NATIONAL WTLDS INVENTORY LINES",
            "NAVIGABLE WATERWAYS",
            "NAVTEQ ROADS",
            "NID DAMS",
            "NPDES STORMWATER MS4 PERMITS",
            "NPS CONTRACT REGIONS",
            "NPS GRANT FUNDED PROJECTS",
            "NUMERIC NUTRIENT CRITERIA",
            "OER DISTRICTS",
            "OFFICE LOCATIONS",
            "OUTSTANDING FLORIDA WATERS",
            "PADDLING TRAIL OPPORTUNITIES",
            "PARCELS HCPA 2016",
            "PARKS AND REC AREAS",
            "PARKS CAMPING SITES",
            "PARKS ENTRANCES",
            "PARKS NATURAL COMMUNITIES",
            "PARKS POINTS OF INTEREST",
            "PARKS ROADS",
            "PARKS STRUCTURES",
            "PARKS TRAILS",
            "PESTICIDE FLORIDAN AQUIFER",
            "PESTICIDE INTERMEDIATE AQUIFER",
            "PESTICIDE SURFICIAL AQUIFER",
            "PHYSIOGRAPHIC PROVINCES",
            "PHYSIOGRAPHIC REGIONS AREAS",
            "PHYSIOGRAPHIC REGIONS LINES",
            "PLANT CITY SEWER SYSTEM",
            "POPULATED PLACE NAMES",
            "PORTS",
            "POTENTIAL NATURAL AREAS",
            "POWER PLANTS",
            "PRIORITY ECOL GREENWAYS NETWRK",
            "PRIORITY TRAIL OPPORTUNITIES",
            "PROJECTIONS AND DATUMS",
            "PUBLIC LAND SURVEY 100",
            "PUBLIC LAND SURVEY SYSTEM",
            "PUBLIC LAND SURVEY SYSTEM 2006",
            "PUBLIC LANDS",
            "QUAD GRID INDEX",
            "QUAD GRID INDEX 100",
            "QUARTER QUAD GRID INDEX",
            "RAILROADS 24",
            "RAILWAYS 100",
            "RAILWAYS 100 1",
            "SALT MARSHES",
            "SAS DTW",
            "SAS RESPONSE",
            "SCHOOLS JR COLLEGE",
            "SCHOOLS PUB K 12",
            "SCHOOLS PUB UNIV",
            "SCHOOLS PVT K 12",
            "SCHOOLS PVT UNIV",
            "SCHOOLS VO TECH",
            "SEA GRASSES",
            "SEA GRASSES SCARRING",
            "SEWAGE TREATMENT FACILITIES",
            "SINKHOLE TYPES",
            "SOURCE WATER ASSESSMENT AREAS",
            "SPRINGS 2011",
            "SPRINGS 2015",
            "STATE PLANE ZONES",
            "STATEWIDE BMAP AREAS",
            "STATSGO SOILS",
            "STORM SURGE ZONES",
            "STREETMAP",
            "SURF WATER CLASS BOUND AREAS",
            "SURF WATER CLASS BOUND LINES",
            "SWFWMD LANDUSE 2011",
            "SWFWMD SSURGO",
            "TIDAL FLATS",
            "TIGER BLOCK GROUPS 2010",
            "TIGER BLOCKS 2010",
            "TIGER CITIES 2010",
            "TIGER CITIES 2010 CENTROIDS",
            "TIGER INDIAN LANDS AREAS 2010",
            "TIGER LANDMARKS AREAS 2010",
            "TIGER LANDMARKS POINTS 2010",
            "TIGER PLACES 2010",
            "TIGER PLACES 2010 CENTROIDS",
            "TIGER RAIL 2010 LINES",
            "TIGER ROADS 2010",
            "TIGER TRACTS 2010",
            "TIGER URBAN 2010",
            "TMDL BASIN GROUPS",
            "TMDL PLANNING UNITS",
            "TURTLE NESTING BEACHES",
            "US ARMY CORPS DAMS",
            "US CONGRESSIONAL DISTRICTS",
            "US STATES",
            "USGS GAGING STATIONS",
            "USGS POTMAP CONTOURS",
            "USGS ROADS",
            "USNG 10K",
            "USNG 1K",
            "VEGETATIVE COMMUNITIES 1967",
            "WATER 100 AREAS",
            "WATER 100 LINES",
            "WATER MGMT DISTRICT AREAS",
            "WATER RESOURCE CAUTION AREAS",
            "WBIDS SP VW",
            "WBIDS VERIFIED IMPAIRED",
            "WETLANDS",
            "WILDLIFE MANAGEMENT AREAS",
            "WMS FLOWING WATERS RESOURCE",
            "WMS LAKES RESOURCE",
            "WORLD NATIONS",
            "WSRP PRIVATE WELLS",
            "ZIP CODE AREAS",
            "ACQUIRED ELAPP 1000",
            "ADOPT A POND",
            "BROWNFIELDS HC",
            "CAPITAL IMPROVEMENT PROJECTS LINE",
            "CAPITAL IMPROVEMENT PROJECTS POINT",
            "CAPITAL IMPROVEMENT PROJECTS PROPOSED LINE",
            "CAPITAL IMPROVEMENT PROJECTS PROPOSED POINT",
            "CELL TOWERS",
            "CIRCUIT COURT BOUNDARIES",
            "COMMISSIONER DISTRICTS",
            "COMMUNITY BASED PLANNING AREAS",
            "COMMUNITY DEVELOPMENT BLOCK GRANTS",
            "COMMUNITY DEVELOPMENT BLOCK GROUPS",
            "COMMUNITY DEVELOPMENT DISTRICTS",
            "COUNTY COURT BOUNDARIES",
            "DANGEROUS DOGS",
            "DEFICIENT ROADS COUNTY",
            "DEFICIENT ROADS STATE",
            "DESIGNATED TRUCK ROUTES",
            "DEVELOPMENT AGREEMENT PROJECTS",
            "DEVELOPMENTS OF REGIONAL IMPACT",
            "EAGLES NESTS",
            "ELAPP AREAS",
            "EVACUATION ROUTES",
            "EVACUATION SHELTERS",
            "FIRE STATIONS",
            "FUNCTIONALLY CLASSIFIED ROADS",
            "FUTURE LAND USE",
            "GREENWAY RECREATION CORRIDORS",
            "HILLSBOROUGH COUNTY BUILDINGS",
            "HILLSBOROUGH COUNTY LINE",
            "HISTORIC RESOURCES",
            "HOA BOUNDARIES",
            "HOSPITALS",
            "HUBS TRAFFIC CAMERAS",
            "IMPACT FEE ZONES FIRE",
            "IMPACT FEE ZONES PARK",
            "LAND EXCAVATIONS BORROW PITS",
            "LIBRARIES",
            "MAJOR PROJECTS",
            "NEIGHBORHOODS ONR",
            "NO FEE ZONE",
            "PEAK SENSITIVE",
            "PHOSPHATE MINES",
            "PLANNING AREAS",
            "POTABLE WATER WELLFIELD PROTECTION AREA",
            "PUBLIC WORKS SERVICE UNITS",
            "RIGHT OF WAY HC",
            "RIGHT OF WAY PERMIT",
            "SANDBAGS DISTRIBUTION LOCATIONS",
            "SCHOOLS",
            "SECTION TOWNSHIP RANGE",
            "SIDEWALKS",
            "SIGNALIZED INTERSECTIONS",
            "SIGNIFICANT WILDLIFE HABITATS",
            "SOLID WASTE GARBAGE ROUTES",
            "SOLID WASTE RECYCLING ROUTES",
            "SOLID WASTE YARD WASTE ROUTES",
            "STREAMS",
            "SUBDIVISIONS",
            "SURFACE WATER PROTECTION AREAS",
            "TAMPA BAY",
            "VOLUME SENSITIVE AREAS",
            "WATER OVERLAY",
            "WELL HEAD CAPTURE ZONES",
            "WELLHEAD RESOURCE PROTECTION AREAS",
            "WELLS COM TY POTABLE",
            "WELLS PUBLIC PRODUCTION",
            "ZIPCODES",
            "ZONING DISTRICTS",
            "ZONING OVERLAY DISTRICTS"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(13, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox1, "Type Layer Name Here");
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metaDataButton,
            this.showAttributesButton,
            this.clearButton,
            this.okButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(284, 214);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(36, 232);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // metaDataButton
            // 
            this.metaDataButton.AutoSize = false;
            this.metaDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.metaDataButton.Image = ((System.Drawing.Image)(resources.GetObject("metaDataButton.Image")));
            this.metaDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.metaDataButton.Name = "metaDataButton";
            this.metaDataButton.Size = new System.Drawing.Size(30, 30);
            this.metaDataButton.Text = "viewMetadataButton";
            this.metaDataButton.ToolTipText = "Display Meta Data";
            this.metaDataButton.Click += new System.EventHandler(this.metaDataButton_Click);
            // 
            // showAttributesButton
            // 
            this.showAttributesButton.AutoSize = false;
            this.showAttributesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showAttributesButton.Image = ((System.Drawing.Image)(resources.GetObject("showAttributesButton.Image")));
            this.showAttributesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAttributesButton.Name = "showAttributesButton";
            this.showAttributesButton.Size = new System.Drawing.Size(30, 30);
            this.showAttributesButton.ToolTipText = "Show Attribute Table";
            this.showAttributesButton.Click += new System.EventHandler(this.showAttributesButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = false;
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(30, 30);
            this.clearButton.ToolTipText = "Clear All";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = false;
            this.okButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(30, 30);
            this.okButton.ToolTipText = "Add Layers to Table of Contents";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 214);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(268, 214);
            this.checkedListBox1.TabIndex = 9;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.toolTip1.SetToolTip(this.button1, "Search for Layers");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EPC DataPAL v1.0";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEM;
        private System.Windows.Forms.RadioButton radioButtonTrns;
        private System.Windows.Forms.RadioButton radioButtonWtr;
        private System.Windows.Forms.RadioButton radioButtonImg;
        private System.Windows.Forms.RadioButton radioButtonBound;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonWetM;
        private System.Windows.Forms.RadioButton radioButtonWtrM;
        private System.Windows.Forms.RadioButton radioButtonWstM;
        private System.Windows.Forms.RadioButton radioButtonAirM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton metaDataButton;
        private System.Windows.Forms.ToolStripButton showAttributesButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripButton okButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}