/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘APIFirstTest.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir5 = null;
        public BindDirection bind_dir6 = null;
        public BindDirection bind_dir7 = null;
        public BindDirection bind_dir8 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity14 = null;
        public BindDirection bind_dir9 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity14_Policy = null;
        public BindDirection bind_dir10 = null;
        public BindDirection bind_dir11 = null;
        public BindDirection bind_dir12 = null;
        public BindDirection bind_dir13 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity10 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity10");
            _flow.DataFetchActivity7 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity7");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.DataExporterActivity9 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity9");
            _flow.DataExporterActivity12 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity12");
            _flow.DataExporterCloseActivity13 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity13");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity8 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity8");
            _flow.DataDisconnectActivity11 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity11");
            this.DataCursorActivity14 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity14");
            this.DataCursorActivity14_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence6 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence6");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.DataFetchActivity10.Comment = @"";
            _flow.DataFetchActivity10.IconPath = @"";
            _flow.DataFetchActivity10.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity10.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity10_QueryParameters_Document = new XmlDocument();
            DataFetchActivity10_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity10Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>56bc6bdf-f065-48ad-aa34-95d5ed9d6302</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>Citypairs!Output</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>False</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>Citypairs</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{Citypairs!Output.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Output$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity10_QueryParameters_Document.LoadXml(xmlDataFetchActivity10Params);
            _flow.DataFetchActivity10.QueryParameters = DataFetchActivity10_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("Citypairs!Output", _flow.DataFetchActivity10);
            this.Activities.Add (_flow.DataFetchActivity10);
            _flow.DataFetchActivity7.Comment = @"";
            _flow.DataFetchActivity7.IconPath = @"";
            _flow.DataFetchActivity7.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity7.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity7_QueryParameters_Document = new XmlDocument();
            DataFetchActivity7_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity7Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>4eb850c2-4205-4013-9adb-6148c23c946b</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>Citypairs!Input</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>False</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>Citypairs</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{Citypairs!Input.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Input$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity7_QueryParameters_Document.LoadXml(xmlDataFetchActivity7Params);
            _flow.DataFetchActivity7.QueryParameters = DataFetchActivity7_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("Citypairs!Input", _flow.DataFetchActivity7);
            this.Activities.Add (_flow.DataFetchActivity7);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            _flow.StartActivity1.KafkaSSL = new HP.ST.Fwk.KafkaFWK.KafkaSSLProperties();
            _flow.StartActivity1.IsKafkaUsed = false;
            _flow.StartActivity1.KafkaSSL.StrEnableSSL = @"No";
            _flow.StartActivity1.KafkaSSL.SSLCALocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyStoreLocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyStorePassword = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyPassword = @"";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 4 iterations";
            _flow.Loop2.NumberOfIterations = (int)4;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity14);
            _flow.Loop2.Activities.Add (_flow.Sequence6);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity9.Comment = @"";
            _flow.DataExporterActivity9.IconPath = @"";
            VTDPropertyInfoBase pi9 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter5 = new VTDObjectGetter(pi9);
            VTDPropertyInfoBase pi10 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter5 = new VTDObjectSetter(pi10);
            binding_setter5 = new StringFormaterDecorator(binding_setter5,"{Step.DataFetchActivity7.OutTable}");
            bind_dir5 = new BindDirection(_flow.DataFetchActivity7,binding_getter5,binding_setter5,BindTargetType.ToInProperty);
            _flow.DataExporterActivity9.InDirections.Add(bind_dir5);
            this.Activities.Add (_flow.DataExporterActivity9);
            _flow.DataExporterActivity12.Comment = @"";
            _flow.DataExporterActivity12.IconPath = @"";
            VTDPropertyInfoBase pi11 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter6 = new VTDObjectGetter(pi11);
            VTDPropertyInfoBase pi12 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter6 = new VTDObjectSetter(pi12);
            binding_setter6 = new StringFormaterDecorator(binding_setter6,"{Step.DataFetchActivity10.OutTable}");
            bind_dir6 = new BindDirection(_flow.DataFetchActivity10,binding_getter6,binding_setter6,BindTargetType.ToInProperty);
            _flow.DataExporterActivity12.InDirections.Add(bind_dir6);
            this.Activities.Add (_flow.DataExporterActivity12);
            _flow.DataExporterCloseActivity13.Comment = @"";
            _flow.DataExporterCloseActivity13.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity13);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity8.Comment = @"";
            _flow.DataDisconnectActivity8.IconPath = @"";
            VTDPropertyInfoBase pi13 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter7 = new VTDObjectGetter(pi13);
            VTDPropertyInfoBase pi14 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter7 = new VTDObjectSetter(pi14);
            binding_setter7 = new StringFormaterDecorator(binding_setter7,"{Step.DataFetchActivity7.OutTable}");
            bind_dir7 = new BindDirection(_flow.DataFetchActivity7,binding_getter7,binding_setter7,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity8.InDirections.Add(bind_dir7);
            this.Activities.Add (_flow.DataDisconnectActivity8);
            _flow.DataDisconnectActivity11.Comment = @"";
            _flow.DataDisconnectActivity11.IconPath = @"";
            VTDPropertyInfoBase pi15 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter8 = new VTDObjectGetter(pi15);
            VTDPropertyInfoBase pi16 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter8 = new VTDObjectSetter(pi16);
            binding_setter8 = new StringFormaterDecorator(binding_setter8,"{Step.DataFetchActivity10.OutTable}");
            bind_dir8 = new BindDirection(_flow.DataFetchActivity10,binding_getter8,binding_setter8,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity11.InDirections.Add(bind_dir8);
            this.Activities.Add (_flow.DataDisconnectActivity11);
            this.DataCursorActivity14.Comment = @"";
            this.DataCursorActivity14.IconPath = @"";
            VTDPropertyInfoBase pi17 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter9 = new VTDObjectGetter(pi17);
            VTDPropertyInfoBase pi18 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter9 = new VTDObjectSetter(pi18);
            binding_setter9 = new StringFormaterDecorator(binding_setter9,"{Step.DataFetchActivity7.OutTable}");
            bind_dir9 = new BindDirection(_flow.DataFetchActivity7,binding_getter9,binding_setter9,BindTargetType.ToInProperty);
            this.DataCursorActivity14.InDirections.Add(bind_dir9);
            this.DataCursorActivity14_Policy.StartPosition = CursorStartPosition.UserSpecificRecord;
            this.DataCursorActivity14_Policy.StartAtSpecificRow = 2;
            this.DataCursorActivity14_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity14_Policy.EndAtSpecificRow = 8;
            this.DataCursorActivity14_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity14_Policy.StepSize = 2;
            this.DataCursorActivity14_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Stay;
            this.DataCursorActivity14.Policy = this.DataCursorActivity14_Policy;
            this.DataCursorActivity14.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity14.ResetCursor;
            _flow.Sequence6.Comment = @"";
            _flow.Sequence6.IconPath = @"";
            _flow.Sequence6.Name = @"Sequence6";
            _flow.Sequence6.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence6.Activities.Add (_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>{DataSource.Citypairs!Input.DepartureCity}</DepartureCity><ArrivalCity>{DataSource.Citypairs!Input.ArrivalCity}</ArrivalCity><FlightDate>2023-01-21T00:00:00+00:00</FlightDate></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"GetFlights";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi19 = new VTDPropertyInfoBase("DepartureCity");
            VTDBaseGetter binding_getter10 = new VTDObjectGetter(pi19);
            VTDPropertyInfoBase pi20 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='DepartureCity'][1]");
            VTDBaseSetter binding_setter10 = new VTDXPathSetter(pi20,XmlTypeCode.String);
            binding_setter10 = new StringFormaterDecorator(binding_setter10,"{DataSource.Citypairs!Input.DepartureCity}");
            bind_dir10 = new BindDirection(this.DataCursorActivity14,binding_getter10,binding_setter10,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir10);
            VTDPropertyInfoBase pi21 = new VTDPropertyInfoBase("ArrivalCity");
            VTDBaseGetter binding_getter11 = new VTDObjectGetter(pi21);
            VTDPropertyInfoBase pi22 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='ArrivalCity'][1]");
            VTDBaseSetter binding_setter11 = new VTDXPathSetter(pi22,XmlTypeCode.String);
            binding_setter11 = new StringFormaterDecorator(binding_setter11,"{DataSource.Citypairs!Input.ArrivalCity}");
            bind_dir11 = new BindDirection(this.DataCursorActivity14,binding_getter11,binding_setter11,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir11);
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightsResult><Flight><Airline p1:nil=""true"" /><ArrivalCity p1:nil=""true"" /><ArrivalTime p1:nil=""true"" /><DepartureCity p1:nil=""true"" /><DepartureTime p1:nil=""true"" /><FlightNumber /></Flight></GetFlightsResult></GetFlightsResponse></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Business</Class><CustomerName>Peter Venkman</CustomerName><DepartureDate>{Step.InputProperties.StServiceCallActivity4.Body.GetFlights.FlightDate}</DepartureDate><FlightNumber>{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightsResponse.GetFlightsResult.Flight[1].FlightNumber}</FlightNumber><NumberOfTickets>3</NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity5.InputEnvelope = StServiceCallActivity5_InputEnvelope_Document;
            _flow.StServiceCallActivity5.Comment = @"";
            _flow.StServiceCallActivity5.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity5.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity5.Service = @"Flights_Service";
            _flow.StServiceCallActivity5.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity5.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity5.IsOneWay = false;
            _flow.StServiceCallActivity5.SendRequestToService=true;
            _flow.StServiceCallActivity5.FaultExpected=false;
            _flow.StServiceCallActivity5.IsAsync=false;
            _flow.StServiceCallActivity5.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity5.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi23 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightsResponse'][1]/*[local-name(.)='GetFlightsResult'][1]/*[local-name(.)='Flight'][{Array0}]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseGetter binding_getter12 = new VTDXPathGetter(pi23,XmlTypeCode.Int);
            binding_getter12 = new XPathGetterDecorator(binding_getter12,"{Array0}",1);
            VTDPropertyInfoBase pi24 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseSetter binding_setter12 = new VTDXPathSetter(pi24,XmlTypeCode.Int);
            bind_dir12 = new BindDirection(_flow.StServiceCallActivity4,binding_getter12,binding_setter12,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir12);
            VTDPropertyInfoBase pi25 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='FlightDate'][1]");
            VTDBaseGetter binding_getter13 = new VTDXPathGetter(pi25,XmlTypeCode.DateTime);
            VTDPropertyInfoBase pi26 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='DepartureDate'][1]");
            VTDBaseSetter binding_setter13 = new VTDXPathSetter(pi26,XmlTypeCode.DateTime);
            bind_dir13 = new BindDirection(_flow.StServiceCallActivity4,binding_getter13,binding_setter13,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir13);
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><CreateFlightOrderResult><OrderNumber>90</OrderNumber><TotalPrice>500</TotalPrice></CreateFlightOrderResult></CreateFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    