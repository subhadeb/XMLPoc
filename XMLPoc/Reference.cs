using System.Xml.Serialization;
using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ComponentModel;
using System.Diagnostics;

namespace Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient
{
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [XmlTypeAttribute(TypeName = "SSPDCMessageTypeMessageClassification", Namespace = "http://schemas.datacontract.org/2004/07/")]
    public enum SSPDCMessageTypeMessageClassification1
    {

        confirm,


        errors,


        warning,
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [XmlTypeAttribute(TypeName = "YesNoType", Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public enum YesNoType1
    {

        Y,


        N,


        U,
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public enum YesNoCode
    {

        Y,


        N,


        U,
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public enum YesNoType
    {

        Y,


        N,


        U,
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public enum SSPDCMessageTypeMessageClassification
    {

        confirm,


        errors,


        warning,
    }
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", ConfigurationName = "SSPDCClient.ISSPDCIntegrationService")]
    public interface ISSPDCIntegrationService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationResponseSubmitApplicationResult submitApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationResponseSubmitApplicationResult> submitApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);


        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedData", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationForPrepopulatedDataResponseSubmitApplicationForPrepopulatedDataResult submitApplicationForPrepopulatedData(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedData", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationForPrepopulatedDataResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationForPrepopulatedDataResponseSubmitApplicationForPrepopulatedDataResult> submitApplicationForPrepopulatedDataAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);



        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitSNAPShortApplicationResponseSubmitSNAPShortApplicationResult submitSNAPShortApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itSNAPShortApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitSNAPShortApplicationResponseSubmitSNAPShortApplicationResult> submitSNAPShortApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitDisasterSNAPApplicationResponseSubmitDisasterSNAPApplicationResult submitDisasterSNAPApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itDisasterSNAPApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitDisasterSNAPApplicationResponseSubmitDisasterSNAPApplicationResult> submitDisasterSNAPApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application);

        // CODEGEN: Parameter 'applicationNumber' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/ReRu" +
            "nApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/ReRu" +
            "nApplicationResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponse ReRunApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/ReRu" +
            "nApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/ReRu" +
            "nApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponse> ReRunApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/remo" +
            "valOfMAAssisstance", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/remo" +
            "valOfMAAssisstanceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/remo" +
            "valOfMAAssisstanceFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool removalOfMAAssisstance(int individualId, int caseNumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/remo" +
            "valOfMAAssisstance", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/remo" +
            "valOfMAAssisstanceResponse")]
        System.Threading.Tasks.Task<bool> removalOfMAAssisstanceAsync(int individualId, int caseNumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPE", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEResponseSubmitPEResult SubmitPE(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEApplication Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPE", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPEResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEResponseSubmitPEResult> SubmitPEAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEApplication Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itAdditionalApplicationDetails", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itAdditionalApplicationDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itAdditionalApplicationDetailsFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitAdditionalApplicationDetailsResponseSubmitAdditionalApplicationDetailsResult SubmitAdditionalApplicationDetails(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.AdditionalApplicationDetails additionalApplicationDetails);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itAdditionalApplicationDetails", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itAdditionalApplicationDetailsResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitAdditionalApplicationDetailsResponseSubmitAdditionalApplicationDetailsResult> SubmitAdditionalApplicationDetailsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.AdditionalApplicationDetails additionalApplicationDetails);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChange", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeResponseSubmitApplicationChangeResult submitApplicationChange(
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication oldXML, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication newXML);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChange", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeResponseSubmitApplicationChangeResult> submitApplicationChangeAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication oldXML, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication newXML);

        //[System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChange", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeResponse")]
        //[System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        //[System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        //[System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        //[System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        //[System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
        //    "itApplicationChangeFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddress", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
   "itApplicationChangeAddressDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]

        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeAddressResponseSubmitApplicationChangeAddressResult submitApplicationChangeAddress(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeAddress", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/subm" +
            "itApplicationChangeAddressResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeAddressResponseSubmitApplicationChangeAddressResult> submitApplicationChangeAddressAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application);



        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/dete" +
            "rmineEligibility", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/dete" +
            "rmineEligibilityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/dete" +
            "rmineEligibilityDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityResponseDetermineEligibilityResult determineEligibility(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityApplication Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/dete" +
            "rmineEligibility", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/dete" +
            "rmineEligibilityResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityResponseDetermineEligibilityResult> determineEligibilityAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityApplication Application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/addN" +
            "ewBorn", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/addN" +
            "ewBornResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/addN" +
            "ewBornDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornResponseAddNewBornResult addNewBorn(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornApplication application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/addN" +
            "ewBorn", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/addN" +
            "ewBornResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornResponseAddNewBornResult> addNewBornAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornApplication application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/upda" +
            "teAgency", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/upda" +
            "teAgencyResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool updateAgency(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation agencyInput, string Operation);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/upda" +
            "teAgency", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/upda" +
            "teAgencyResponse")]
        System.Threading.Tasks.Task<bool> updateAgencyAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation agencyInput, string Operation);

        // CODEGEN: Parameter 'taskAttributes' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/crea" +
            "teTask", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/crea" +
            "teTaskResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse createTask(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/crea" +
            "teTask", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/crea" +
            "teTaskResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse> createTaskAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teTasks", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teTasksResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool UpdateTasks(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel tasks);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teTasks", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teTasksResponse")]
        System.Threading.Tasks.Task<bool> UpdateTasksAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel tasks);

        // CODEGEN: Parameter 'taskAttributes' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Crea" +
            "teTasks", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Crea" +
            "teTasksResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse CreateTasks(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Crea" +
            "teTasks", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Crea" +
            "teTasksResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse> CreateTasksAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTC", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[] CalculateMaxAPTC(int caseNumber, int coverageYear);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTC", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[]> CalculateMaxAPTCAsync(int caseNumber, int coverageYear);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCWithUserRole", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCWithUserRoleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[] CalculateMaxAPTCWithUserRole(int caseNumber, int coverageYear, string userRole);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCWithUserRole", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Calc" +
            "ulateMaxAPTCWithUserRoleResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[]> CalculateMaxAPTCWithUserRoleAsync(int caseNumber, int coverageYear, string userRole);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teIndividualMCI", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teIndividualMCIResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool UpdateIndividualMCI(int individualid, int mciID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teIndividualMCI", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teIndividualMCIResponse")]
        System.Threading.Tasks.Task<bool> UpdateIndividualMCIAsync(int individualid, int mciID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Togg" +
            "leDownTimeStatus", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Togg" +
            "leDownTimeStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        void ToggleDownTimeStatus(string availabilityStatus);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Togg" +
            "leDownTimeStatus", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Togg" +
            "leDownTimeStatusResponse")]
        System.Threading.Tasks.Task ToggleDownTimeStatusAsync(string availabilityStatus);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Gete" +
            "DownTimeStatus", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Gete" +
            "DownTimeStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        string GeteDownTimeStatus();

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Gete" +
            "DownTimeStatus", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Gete" +
            "DownTimeStatusResponse")]
        System.Threading.Tasks.Task<string> GeteDownTimeStatusAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teContactDetails", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teContactDetailsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool UpdateContactDetails(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Individual individualDetails, int caseNumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teContactDetails", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Upda" +
            "teContactDetailsResponse")]
        System.Threading.Tasks.Task<bool> UpdateContactDetailsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Individual individualDetails, int caseNumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itIndividualRelationships", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itIndividualRelationshipsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitIndividualRelationshipsResponseSubmitIndividualRelationshipsResult SubmitIndividualRelationships(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.IndividualRelationships indivRelationships);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itIndividualRelationships", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itIndividualRelationshipsResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitIndividualRelationshipsResponseSubmitIndividualRelationshipsResult> SubmitIndividualRelationshipsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.IndividualRelationships indivRelationships);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetT" +
            "axFilerList", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetT" +
            "axFilerListResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaxFilerModel[] GetTaxFilerList(int casenumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetT" +
            "axFilerList", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetT" +
            "axFilerListResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaxFilerModel[]> GetTaxFilerListAsync(int casenumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Popu" +
            "lateHouseholdComposition", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Popu" +
            "lateHouseholdCompositionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.HouseholdCompositionReturnModel PopulateHouseholdComposition(int casenumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Popu" +
            "lateHouseholdComposition", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Popu" +
            "lateHouseholdCompositionResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.HouseholdCompositionReturnModel> PopulateHouseholdCompositionAsync(int casenumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetC" +
            "aseNumber", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetC" +
            "aseNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        int GetCaseNumber(int IndividualId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetC" +
            "aseNumber", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/GetC" +
            "aseNumberResponse")]
        System.Threading.Tasks.Task<int> GetCaseNumberAsync(int IndividualId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Inse" +
            "rtOrganizationCase", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Inse" +
            "rtOrganizationCaseResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool InsertOrganizationCase(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation organizaionInput);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Inse" +
            "rtOrganizationCase", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Inse" +
            "rtOrganizationCaseResponse")]
        System.Threading.Tasks.Task<bool> InsertOrganizationCaseAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation organizaionInput);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Save" +
            "APTCReview", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Save" +
            "APTCReviewResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        bool SaveAPTCReview(int CaseNumber, string UserRole, string IsReviewSelected, string SpecializedFlag);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Save" +
            "APTCReview", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Save" +
            "APTCReviewResponse")]
        System.Threading.Tasks.Task<bool> SaveAPTCReviewAsync(int CaseNumber, string UserRole, string IsReviewSelected, string SpecializedFlag);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPreCaseApplicationResponseSubmitPreCaseApplicationResult SubmitPreCaseApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itPreCaseApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPreCaseApplicationResponseSubmitPreCaseApplicationResult> SubmitPreCaseApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.BusinessExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationBusinessExceptionTypeFault", Name = "BusinessExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.EDBCExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationEDBCExceptionTypeFault", Name = "EDBCExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FatalExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationFatalExceptionTypeFault", Name = "FatalExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.FileClearenceExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationFileClearenceExceptionTypeFault", Name = "FileClearenceExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DownTimeExceptionType), Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationDownTimeExceptionTypeFault", Name = "DownTimeExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FileClearenceExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCApplicationResponseSubmitDCApplicationResult SubmitDCApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application, int ProcessingID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplication", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCApplicationResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCApplicationResponseSubmitDCApplicationResult> SubmitDCApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application, int ProcessingID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCRepresentativeInfo", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCRepresentativeInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FatalExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EDBCExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DownTimeExceptionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalApplicationDetails))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HouseholdCompositionReturnModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndividualRelationships))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskResponseModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DCAgencyIndividualCaseAssociation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(controlInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TaskAttributes[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MaxAPTCResponse[]))]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCRepresentativeInfoResponseSubmitDCRepresentativeInfoResult SubmitDCRepresentativeInfo(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication application);

        [System.ServiceModel.OperationContractAttribute(Action = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCRepresentativeInfo", ReplyAction = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd/ISSPDCIntegrationService/Subm" +
            "itDCRepresentativeInfoResponse")]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCRepresentativeInfoResponseSubmitDCRepresentativeInfoResult> SubmitDCRepresentativeInfoAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication application);
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class BusinessExceptionType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int aRApplicationNumberField { get; set; }

        [XmlElementAttribute("aRApplicationNumberFieldSpecified", Order = 1)]
        public bool aRApplicationNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int caseNumberField { get; set; }

        [XmlElementAttribute("caseNumberFieldSpecified", Order = 3)]
        public bool caseNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string errorCodeField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string exceptionIdField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string innerExceptionField { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 7)]
        public SSPDCMessageType1[] messagesField { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int sSPDCPorcessingIdField { get; set; }

        [XmlElementAttribute("sSPDCPorcessingIdFieldSpecified", Order = 9)]
        public bool sSPDCPorcessingIdFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string stackTraceField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string transactionIdField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "SSPDCMessageType", Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class SSPDCMessageType1 : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string activityDurationField { get; set; }

        [XmlElementAttribute(Order = 1)]
        public SSPDCMessageTypeMessageClassification1 messageClassificationField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string messageKeyField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string messageTextField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string processIdField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class DownTimeExceptionType : object, System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int aRApplicationNumberField { get; set; }

        [XmlElementAttribute("aRApplicationNumberFieldSpecified", Order = 1)]
        public bool aRApplicationNumberFieldSpecified1 { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 2)]
        public EDCustomDictionary[] additionalInfoField { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int caseNumberField { get; set; }

        [XmlElementAttribute("caseNumberFieldSpecified", Order = 4)]
        public bool caseNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string errorCodeField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string exceptionIdField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string innerExceptionField { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 8)]
        public SSPDCMessageType1[] messagesField { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int sSPDCPorcessingIdField { get; set; }

        [XmlElementAttribute("sSPDCPorcessingIdFieldSpecified", Order = 10)]
        public bool sSPDCPorcessingIdFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string stackTraceField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class FileClearenceExceptionType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int aRApplicationNumberField { get; set; }

        [XmlElementAttribute("aRApplicationNumberFieldSpecified", Order = 1)]
        public bool aRApplicationNumberFieldSpecified1 { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 2)]
        public EDCustomDictionary[] additionalInfoField { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int caseNumberField { get; set; }

        [XmlElementAttribute("caseNumberFieldSpecified", Order = 4)]
        public bool caseNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string errorCodeField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string exceptionIdField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string innerExceptionField { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 8)]
        public SSPDCMessageType1[] messagesField { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int sSPDCPorcessingIdField { get; set; }

        [XmlElementAttribute("sSPDCPorcessingIdFieldSpecified", Order = 10)]
        public bool sSPDCPorcessingIdFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string stackTraceField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class EDCustomDictionary : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string keyField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string valueField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class FatalExceptionType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int aRApplicationNumberField { get; set; }

        [XmlElementAttribute("aRApplicationNumberFieldSpecified", Order = 1)]
        public bool aRApplicationNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int caseNumberField { get; set; }

        [XmlElementAttribute("caseNumberFieldSpecified", Order = 3)]
        public bool caseNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string errorCodeField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string exceptionIdField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string innerExceptionField { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 7)]
        public SSPDCMessageType1[] messagesField { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int sSPDCPorcessingIdField { get; set; }

        [XmlElementAttribute("sSPDCPorcessingIdFieldSpecified", Order = 9)]
        public bool sSPDCPorcessingIdFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string stackTraceField { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/")]
    public class EDBCExceptionType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int aRApplicationNumberField { get; set; }

        [XmlElementAttribute("aRApplicationNumberFieldSpecified", Order = 1)]
        public bool aRApplicationNumberFieldSpecified1 { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 2)]
        public EDCustomDictionary[] additionalInfoField { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int caseNumberField { get; set; }

        [XmlElementAttribute("caseNumberFieldSpecified", Order = 4)]
        public bool caseNumberFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string errorCodeField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string exceptionIdField { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string innerExceptionField { get; set; }

        [XmlArrayAttribute(IsNullable = true, Order = 8)]
        public SSPDCMessageType1[] messagesField { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int sSPDCPorcessingIdField { get; set; }

        [XmlElementAttribute("sSPDCPorcessingIdFieldSpecified", Order = 10)]
        public bool sSPDCPorcessingIdFieldSpecified1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string stackTraceField { get; set; }
    }
    [XmlIncludeAttribute(typeof(NCPChildModelPostElg))]
    [XmlIncludeAttribute(typeof(NonCustodialParentRelationshipPostElg))]
    [XmlIncludeAttribute(typeof(NonCustodialParentPostElg))]
    [XmlIncludeAttribute(typeof(NCPEmployerInformationPostElg))]
    [XmlIncludeAttribute(typeof(NCPComplianceDetailsPostElg))]
    [XmlIncludeAttribute(typeof(NCPJointCustodyPostElg))]
    [XmlIncludeAttribute(typeof(NCPStatusPostElg))]
    [XmlIncludeAttribute(typeof(WaiverDetails))]
    [XmlIncludeAttribute(typeof(IndividualInformation))]
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "controlInfo", Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class controlInfo1 : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        protected System.Nullable<bool> _updateIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<bool> updateIndicator
        {
            get { return _updateIndicator; }
            set
            {
                _updateIndicator = value;
                updateIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool updateIndicatorSpecified { get; set; }

        protected System.Nullable<bool> _deleteIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<bool> deleteIndicator
        {
            get { return _deleteIndicator; }
            set
            {
                _deleteIndicator = value;
                deleteIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool deleteIndicatorSpecified { get; set; }

        protected System.Nullable<bool> _addIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<bool> addIndicator
        {
            get { return _addIndicator; }
            set
            {
                _addIndicator = value;
                addIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool addIndicatorSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NCPChildModelPostElg : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute("NonCustodialParentRelationshipPostElg", Order = 1)]
        public NonCustodialParentRelationshipPostElg[] NonCustodialParentRelationshipPostElg { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NonCustodialParentRelationshipPostElg : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        protected System.Nullable<int> _ResponsibleIndividualID;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> ResponsibleIndividualID
        {
            get { return _ResponsibleIndividualID; }
            set
            {
                _ResponsibleIndividualID = value;
                ResponsibleIndividualIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResponsibleIndividualIDSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string StatusOnChildBirth { get; set; }

        protected System.Nullable<YesNoType1> _HasChildSupport;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType1> HasChildSupport
        {
            get { return _HasChildSupport; }
            set
            {
                _HasChildSupport = value;
                HasChildSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasChildSupportSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public NonCustodialParentPostElg NonCustodialParentPostElg { get; set; }

        [XmlElementAttribute("NCPComplianceDetailsPostElg", Order = 5)]
        public NCPComplianceDetailsPostElg[] NCPComplianceDetailsPostElg { get; set; }

        [XmlElementAttribute("NCPJointCustodyPostElg", Order = 6)]
        public NCPJointCustodyPostElg[] NCPJointCustodyPostElg { get; set; }

        [XmlElementAttribute("NCPStatusPostElg", Order = 7)]
        public NCPStatusPostElg[] NCPStatusPostElg { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int NonCustodialParentSequenceNumber { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NonCustodialParentPostElg : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public int NonCustodialParentSequenceNumber { get; set; }

        protected int _SSPNonCustodialParentSequenceNumber;

        [XmlElementAttribute(Order = 1)]
        public int SSPNonCustodialParentSequenceNumber
        {
            get { return _SSPNonCustodialParentSequenceNumber; }
            set
            {
                _SSPNonCustodialParentSequenceNumber = value;
                SSPNonCustodialParentSequenceNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPNonCustodialParentSequenceNumberSpecified { get; set; }

        protected System.Nullable<YesNoType1> _HasChildSupport;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType1> HasChildSupport
        {
            get { return _HasChildSupport; }
            set
            {
                _HasChildSupport = value;
                HasChildSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasChildSupportSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string FirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string LastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string MiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string SuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string GenderCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string ParentSsn { get; set; }

        protected System.Nullable<System.DateTime> _ParentDateOfBirth;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<System.DateTime> ParentDateOfBirth
        {
            get { return _ParentDateOfBirth; }
            set
            {
                _ParentDateOfBirth = value;
                ParentDateOfBirthSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ParentDateOfBirthSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string PlaceOfEmployment { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string CountryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string ZipCode5 { get; set; }

        protected System.Nullable<YesNoType1> _IsParentUnknown;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<YesNoType1> IsParentUnknown
        {
            get { return _IsParentUnknown; }
            set
            {
                _IsParentUnknown = value;
                IsParentUnknownSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsParentUnknownSpecified { get; set; }

        [XmlElementAttribute(Order = 20)]
        public string IsAbsentParentParentsKnown { get; set; }

        [XmlElementAttribute(Order = 21)]
        public string IsAbsentParentEmploymentKnown { get; set; }

        [XmlElementAttribute(Order = 22)]
        public string HasCourtAction { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string IsMoneyReceivedFromAbsentParent { get; set; }

        [XmlElementAttribute(Order = 24)]
        public string HasIndividualLivedWithAbsentParent { get; set; }

        [XmlElementAttribute(Order = 25)]
        public string IsWillingForPaternity { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public NCPEmployerInformationPostElg NCPEmployerInformationPostElg { get; set; }

        [XmlElementAttribute("NonCustodialParentRelationshipPostElg", IsNullable = true, Order = 27)]
        public NonCustodialParentRelationshipPostElg[] NonCustodialParentRelationshipPostElg { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NCPEmployerInformationPostElg : controlInfo1
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string CountryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string ZipCode5 { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NCPComplianceDetailsPostElg : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string GoodCauseCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string NonCustodialParentStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string GoodCauseVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string Comments { get; set; }

        protected System.Nullable<YesNoType1> _IsApplicantCooperative;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType1> IsApplicantCooperative
        {
            get { return _IsApplicantCooperative; }
            set
            {
                _IsApplicantCooperative = value;
                IsApplicantCooperativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsApplicantCooperativeSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NCPJointCustodyPostElg : controlInfo1
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string Is5050JointCustody { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string NonCustodialParentStatusCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class NCPStatusPostElg : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public string DesertationTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _DeathDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> DeathDate
        {
            get { return _DeathDate; }
            set
            {
                _DeathDate = value;
                DeathDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DeathDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IntendToReturnHome { get; set; }

        protected System.Nullable<System.DateTime> _ExpectedReleaseOrDischargeDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> ExpectedReleaseOrDischargeDate
        {
            get { return _ExpectedReleaseOrDischargeDate; }
            set
            {
                _ExpectedReleaseOrDischargeDate = value;
                ExpectedReleaseOrDischargeDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpectedReleaseOrDischargeDateSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class WaiverDetails : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public YesNoType1 SelectedABICode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public YesNoType1 IsDependentOnVentilator { get; set; }

        [XmlElementAttribute(Order = 2)]
        public YesNoType1 RequiresAssistanceCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public YesNoType1 HasIntellectualDisabilityCode { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int WaiverScreeningId { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string LikeToContinueReceivingServicesCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class IndividualInformation : controlInfo1
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoCode> IsTobaccoUser { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoCode> ISUSVeteran { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_ADDITIONALDETAILS_REG_V1.0.xsd")]
    public class AdditionalApplicationDetails : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string IsApplicantRegisteredToVote { get; set; }

        [XmlElementAttribute("IndividualInformation", IsNullable = true, Order = 1)]
        public IndividualInformation[] IndividualInformation { get; set; }

        [XmlElementAttribute("NCPChildModelPostElg", Order = 2)]
        public NCPChildModelPostElg[] NCPChildModelPostElg { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        [XmlElementAttribute("WaiverDetails", IsNullable = true, Order = 4)]
        public WaiverDetails[] WaiverDetails { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class HouseholdCompositionReturnModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public bool IsSuccess { get; set; }

        [XmlArrayAttribute(Order = 1)]
        public TaxFilerModel[] TaxFilerList { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaxFilerModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int TaxFilerId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int CoverageYear { get; set; }

        [XmlElementAttribute(Order = 2)]
        public System.DateTime TaxFilerBirthDate { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string TaxFilerRelationshipTypeCode { get; set; }

        [XmlArrayAttribute(Order = 4)]
        public TaxStatusModel[] TaxStatusModelList { get; set; }

        [XmlArrayAttribute(Order = 5)]
        public TaxFilerRelationshipModel[] RelationshipModelList { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaxStatusModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string TaxGroupStatus { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaxFilerRelationshipModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int RelatedIndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string RelationshipTypeCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Relationships : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> AdoptionDate { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string IsAdopted { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string IsCaretaker { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string RelatedIndividualGender { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int RelatedIndividualId { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string RelatedIndividualName { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int RelationshipSequenceNumber { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string RelationshipTypeCode { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string RelationshipVerificationCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualRelationships : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int caseNumber { get; set; }

        [XmlArrayAttribute(Order = 1)]
        public Relationships[] relationshipsList { get; set; }

        [XmlElementAttribute(Order = 2)]
        public System.DateTime ApplicationReceivedDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class APTC : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public decimal MaxAPTCAmount { get; set; }

        [XmlElementAttribute(Order = 1)]
        public decimal RemainderBHC { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IRSResponse : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public APTC APTCDetail { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string RequestID { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string SystemCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NonESIMECResponseMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string ResponseCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResponseDescriptionText { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string TDSResponseDescriptionText { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ErrorMessageDetail : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public NonESIMECResponseMetadata NonESIMECMetadataResponse { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class MaxAPTCResponse : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayAttribute(Order = 0)]
        public ErrorMessageDetail[] ErrorMessage { get; set; }

        [XmlElementAttribute(Order = 1)]
        public IRSResponse IRSResponseDetail { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskResponseModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int TaskId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ErrorMessage { get; set; }

        [XmlElementAttribute(Order = 2)]
        public bool TaskCreationSuccessIndicator { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string ErrorDetail { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string StackTrace { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string ErrorCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskAttributes : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string key { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string value { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class WorkflowAttributesModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> ApplicationNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> AppointmentId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<int> AssignedToEmployeeId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> AssessmentId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<int> CaseNoteId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> DueDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<int> IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<bool> IsExternalEmployee { get; set; }

        [XmlElementAttribute(Order = 10)]
        public string MeetingMonth { get; set; }

        [XmlElementAttribute(Order = 11)]
        public string NextAction { get; set; }

        [XmlElementAttribute(Order = 12)]
        public string NoteTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<int> OrganizationId { get; set; }

        [XmlElementAttribute(Order = 14)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ReceivedDate { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string TaskClosureComments { get; set; }

        [XmlElementAttribute(Order = 17)]
        public string TaskComments { get; set; }

        [XmlElementAttribute(Order = 18)]
        public string TaskTypeCode { get; set; }

        [XmlElementAttribute(Order = 19)]
        public string TaskName { get; set; }

        [XmlElementAttribute(Order = 20)]
        public string NotificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public System.Nullable<int> RecipientId { get; set; }

        [XmlElementAttribute(Order = 22)]
        public string RecipientType { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string LoggedInUser { get; set; }

        [XmlElementAttribute(Order = 24)]
        public string AreAllServicesPriorAuthorized { get; set; }

        [XmlElementAttribute(Order = 25)]
        public string AssignedTo { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<int> AssignedToUserId { get; set; }

        [XmlElementAttribute(Order = 27)]
        public string CurrentUserRole { get; set; }

        [XmlElementAttribute(Order = 28)]
        public string HasConflict { get; set; }

        [XmlElementAttribute(Order = 29)]
        public string HasException { get; set; }

        [XmlElementAttribute(Order = 30)]
        public string IsExceptionApproved { get; set; }

        [XmlElementAttribute(Order = 31)]
        public string IsOrgReviewNeeded { get; set; }

        [XmlElementAttribute(Order = 32)]
        public string IsRevisionsRequested { get; set; }

        [XmlElementAttribute(Order = 33)]
        public string PlanCategoryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<int> PocId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<bool> IsReconsiderationRequested { get; set; }

        [XmlElementAttribute(Order = 36)]
        public string IsPocConflictApproved { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<bool> IsAcceptProgramClosureRequest { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public System.Nullable<int> POCCaseManagerId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public System.Nullable<int> POCCaseSupervisorId { get; set; }

        [XmlElementAttribute(Order = 40)]
        public string SubmittedByUserName { get; set; }

        [XmlElementAttribute(Order = 41)]
        public string HrstFlag { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<bool> IsAcceptRequest { get; set; }

        [XmlElementAttribute(Order = 43)]
        public string ExternalTransferResponse { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<bool> IsCaseTransfer { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public System.Nullable<bool> HasCaseTransferConflict { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<bool> IsConflictApproved { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<bool> IsExternalTransfer { get; set; }

        [XmlElementAttribute(Order = 48)]
        public string WorkflowPath { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public System.Nullable<bool> IsInabilityTaskOpen { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 50)]
        public System.Nullable<bool> IsCaseNoteSubmitted { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 51)]
        public System.Nullable<bool> IsCancelRequest { get; set; }

        [XmlElementAttribute(Order = 52)]
        public string InitialCaseAssignmentResponse { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 53)]
        public System.Nullable<int> LoggedInOrganizationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public System.Nullable<bool> IsReasonMatched { get; set; }

        [XmlElementAttribute(Order = 55)]
        public string ProgramStatus { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<bool> IsCaseManagerAssigned { get; set; }

        [XmlElementAttribute(Order = 57)]
        public string CreateMultipleTask { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 58)]
        public System.Nullable<bool> IsCaseManagerTransfer { get; set; }

        [XmlElementAttribute(Order = 59)]
        public string IndividualIdList { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 60)]
        public System.Nullable<int> LoggedInUserEmployeeId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 61)]
        public System.Nullable<bool> IsLoggedInUserExternal { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 62)]
        public System.Nullable<System.DateTime> InabilityStartDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 63)]
        public System.Nullable<System.DateTime> RecordCreatedDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 64)]
        public System.Nullable<System.DateTime> AnticipatedEndDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<System.DateTime> ActualEndDate { get; set; }

        [XmlElementAttribute(Order = 66)]
        public string CMAFirstName { get; set; }

        [XmlElementAttribute(Order = 67)]
        public string CMALastName { get; set; }

        [XmlElementAttribute(Order = 68)]
        public string AnotherWaiverRefferred { get; set; }

        [XmlElementAttribute(Order = 69)]
        public string AnyChangesDoneToApplication { get; set; }

        [XmlElementAttribute(Order = 70)]
        public string ApplicationInitiatedBy { get; set; }

        [XmlElementAttribute(Order = 71)]
        public string ApplicationStatus { get; set; }

        [XmlElementAttribute(Order = 72)]
        public string AgreeWithTargetingCriteria { get; set; }

        [XmlElementAttribute(Order = 73)]
        public string DoesMeetTargetingCriteriaForAnotherWaiver { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public System.Nullable<int> GeneratedDocumentId { get; set; }

        [XmlElementAttribute(Order = 75)]
        public string IsApplicationComplete { get; set; }

        [XmlElementAttribute(Order = 76)]
        public string IsCapacityReserved { get; set; }

        [XmlElementAttribute(Order = 77)]
        public string IsPartialMatch { get; set; }

        [XmlElementAttribute(Order = 78)]
        public string ProgramSelected { get; set; }

        [XmlElementAttribute(Order = 79)]
        public string UrgencyOfNeed { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public System.Nullable<int> AppIntakeCaseManagerId { get; set; }

        [XmlElementAttribute(Order = 81)]
        public string AppIntakeActionTakenBy { get; set; }

        [XmlElementAttribute(Order = 82)]
        public string AppIntakeInputSource { get; set; }

        [XmlElementAttribute(Order = 83)]
        public string AppIntakeScreenType { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 84)]
        public System.Nullable<int> RecipientId2 { get; set; }

        [XmlElementAttribute(Order = 85)]
        public string RecipientType2 { get; set; }

        [XmlElementAttribute(Order = 86)]
        public string CapacityStatus { get; set; }

        [XmlElementAttribute(Order = 87)]
        public string ProgramCode312 { get; set; }

        [XmlElementAttribute(Order = 88)]
        public string WaitlistRemovalReason { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 89)]
        public System.Nullable<bool> IsWaitlistConversion { get; set; }

        [XmlElementAttribute(Order = 90)]
        public string EnrollmentStatusCode { get; set; }

        [XmlElementAttribute(Order = 91)]
        public string AgreeToTransition { get; set; }

        [XmlElementAttribute(Order = 92)]
        public string AppointmentStatusCode { get; set; }

        [XmlElementAttribute(Order = 93)]
        public string AssessmentReason { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 94)]
        public System.Nullable<bool> HasLOCDeterminationStatusChanged { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 95)]
        public System.Nullable<bool> IsMetforAnotherWaiver { get; set; }

        [XmlElementAttribute(Order = 96)]
        public string LOCDeterminationCode { get; set; }

        [XmlElementAttribute(Order = 97)]
        public string MedicaidEligibilityStatus { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 98)]
        public System.Nullable<int> AppointmentIdOld { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 99)]
        public System.Nullable<bool> IfPOCExists { get; set; }

        [XmlElementAttribute(Order = 100)]
        public string ActionTakenByLOCAssessor { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 101)]
        public System.Nullable<int> LocDeterminationId { get; set; }

        [XmlElementAttribute(Order = 102)]
        public string IsAgencyKnown { get; set; }

        [XmlElementAttribute(Order = 103)]
        public string EnrollmentSource { get; set; }

        [XmlElementAttribute(Order = 104)]
        public string WFInitiatedFrom { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 105)]
        public System.Nullable<System.DateTime> LocMetDate { get; set; }

        [XmlElementAttribute(Order = 106)]
        public string RespondentNetwork { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 107)]
        public System.Nullable<bool> ChangeAssessmentAgency { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 108)]
        public System.Nullable<bool> IsLocDoneByInternalUser { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 109)]
        public System.Nullable<int> ReferredWaiverId { get; set; }

        [XmlElementAttribute(Order = 110)]
        public string ProgramCodeList { get; set; }

        [XmlElementAttribute(Order = 111)]
        public string LOCReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 112)]
        public System.Nullable<int> TimeSheetReviewId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 113)]
        public System.Nullable<int> PDSEmployeeId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 114)]
        public System.Nullable<int> PayPeriodId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 115)]
        public System.Nullable<int> FinancialManagementAgencyId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 116)]
        public System.Nullable<bool> HasCMApproved { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 117)]
        public System.Nullable<bool> HasIndividualApproved { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 118)]
        public System.Nullable<bool> IsIndividualKYHBE { get; set; }

        [XmlElementAttribute(Order = 119)]
        public string TimeSheetType { get; set; }

        [XmlElementAttribute(Order = 120)]
        public string FMAAction { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 121)]
        public System.Nullable<bool> IsPSA { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 122)]
        public System.Nullable<int> IncidentId { get; set; }

        [XmlElementAttribute(Order = 123)]
        public string ReportType { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 124)]
        public System.Nullable<bool> AdditionalFactFindingNeeded { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 125)]
        public System.Nullable<bool> AdditionalInformationRequested { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 126)]
        public System.Nullable<bool> IsCHFSFactFindingReqd { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 127)]
        public System.Nullable<bool> IsFollowUpSuperVisorRequired { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 128)]
        public System.Nullable<bool> IsFollowUpCaseManagerRequired { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 129)]
        public System.Nullable<bool> IsCMFactFindingRequired { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 130)]
        public System.Nullable<bool> IsCHFSFactFindingRequired { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 131)]
        public System.Nullable<bool> SignOffApproved { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 132)]
        public System.Nullable<int> ReportId { get; set; }

        [XmlElementAttribute(Order = 133)]
        public string CreatedByRole { get; set; }

        [XmlElementAttribute(Order = 134)]
        public string IncidentCategory { get; set; }

        [XmlElementAttribute(Order = 135)]
        public string ReSubmitFollowUp { get; set; }

        [XmlElementAttribute(Order = 136)]
        public string ReportStatus { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 137)]
        public System.Nullable<int> AssignedToProviderSuperVisorId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 138)]
        public System.Nullable<int> AssignedToCaseManagerId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 139)]
        public System.Nullable<int> ProviderSuperVisorOrganizationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 140)]
        public System.Nullable<int> CaseManagerOrganizationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 141)]
        public System.Nullable<bool> ReCategorizationSubmitted { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 142)]
        public System.Nullable<bool> IsCritical { get; set; }

        [XmlElementAttribute(Order = 143)]
        public string SubmittedByRole { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 144)]
        public System.Nullable<bool> IsReSubmission { get; set; }

        [XmlElementAttribute(Order = 145)]
        public string ReportComments { get; set; }

        [XmlElementAttribute(Order = 146)]
        public string IncidentClassification { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 147)]
        public System.Nullable<bool> IsIncidentDeleted { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 148)]
        public System.Nullable<int> CapacityAllocationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 149)]
        public System.Nullable<bool> IsCaseConversion { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 150)]
        public System.Nullable<int> ComplaintId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 151)]
        public System.Nullable<int> MrtDeterminationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 152)]
        public System.Nullable<int> ReferralNumber { get; set; }

        [XmlElementAttribute(Order = 153)]
        public string ApprovalStatus { get; set; }

        [XmlElementAttribute(Order = 154)]
        public string OIGRequest { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 155)]
        public System.Nullable<int> EnrollmentId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 156)]
        public System.Nullable<int> CaseReviewResultId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 157)]
        public System.Nullable<int> FindingSummaryDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 158)]
        public System.Nullable<int> HearingRequestId { get; set; }

        [XmlElementAttribute(Order = 159)]
        public string HearingBranchCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskIndividualModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string KamesIndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int HbeIndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string KamesFirstName { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string KamesLastName { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string KamesMiddleInitial { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string KamesSuffixCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskLandingAttributesModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string LandingAttribute { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string LandingAttributeValue { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int TaskId { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int TaskLandingAttributesId { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int TaskLandingScreenId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> ApplicationNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> AssignedEmployeeId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<int> CaseNumber { get; set; }

        [XmlArrayAttribute(Order = 3)]
        public string[] DocumentTypes { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> DueDate { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string IdentifierId { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string IdentifierIdTypeCode { get; set; }

        [XmlElementAttribute(Order = 7)]
        public bool IsTaskPresent { get; set; }

        [XmlElementAttribute(Order = 8)]
        public bool IsDailCase { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<int> OfficeId { get; set; }

        [XmlElementAttribute(Order = 10)]
        public string OverrideLOT { get; set; }

        [XmlElementAttribute(Order = 11)]
        public string QueueCategoryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> ReceivedDate { get; set; }

        [XmlElementAttribute(Order = 13)]
        public string StatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> TaskAssignmentDate { get; set; }

        [XmlElementAttribute(Order = 15)]
        public string TaskComments { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<int> TaskCompletionTimeInSeconds { get; set; }

        [XmlElementAttribute(Order = 17)]
        public int TaskId { get; set; }

        [XmlArrayAttribute(Order = 18)]
        public TaskLandingAttributesModel[] TaskLandingAttributes { get; set; }

        [XmlElementAttribute(Order = 19)]
        public string TaskLocationCode { get; set; }

        [XmlElementAttribute(Order = 20)]
        public string TaskSourceId { get; set; }

        [XmlElementAttribute(Order = 21)]
        public string TaskTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public System.Nullable<int> UserId { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string SourceSystem { get; set; }

        [XmlElementAttribute(Order = 24)]
        public string KamesCaseNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public System.Nullable<System.DateTime> KamesDueDate { get; set; }

        [XmlElementAttribute(Order = 26)]
        public string FirstName { get; set; }

        [XmlElementAttribute(Order = 27)]
        public string LastName { get; set; }

        [XmlElementAttribute(Order = 28)]
        public string MiddleInitial { get; set; }

        [XmlElementAttribute(Order = 29)]
        public string SuffixCode { get; set; }

        [XmlElementAttribute(Order = 30)]
        public bool SkipQueueLogic { get; set; }

        [XmlElementAttribute(Order = 31)]
        public string LevelOfTraining { get; set; }

        [XmlElementAttribute(Order = 32)]
        public string PilotQueueCategoryCode { get; set; }

        [XmlArrayAttribute(Order = 33)]
        public TaskIndividualModel[] IndividualsList { get; set; }

        [XmlElementAttribute(Order = 34)]
        public string KamesServiceStatusCode { get; set; }

        [XmlElementAttribute(Order = 35)]
        public string LevelOfTrainingCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<System.DateTime> TaskCompletionDate { get; set; }

        [XmlElementAttribute(Order = 37)]
        public bool HasMciFailed { get; set; }

        [XmlElementAttribute(Order = 38)]
        public string MciFailedErrorMessage { get; set; }

        [XmlElementAttribute(Order = 39)]
        public bool HasKamesFailed { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<System.DateTime> HbeCaseDueDate { get; set; }

        [XmlElementAttribute(Order = 41)]
        public string KamesFailedErrorMessage { get; set; }

        [XmlElementAttribute(Order = 42)]
        public string SnapExpedited { get; set; }

        [XmlElementAttribute(Order = 43)]
        public WorkflowAttributesModel WorkflowAttributes { get; set; }

        [XmlElementAttribute(Order = 44)]
        public bool FirstTimeWorkflowCreation { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public TaskPrimaryAttribute[] TaskPrimaryAttribute { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DCAgencyIndividualCaseAssociationModel : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> AgencyId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int CaseNumber { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> AgencyEmployeeId { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int NewAssignment { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string IndividualContactPhone { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string LoggedInUserId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> DoiAgentId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<int> DoiAgencyId { get; set; }

        [XmlElementAttribute(Order = 9)]
        public bool IsAgentUpdate { get; set; }

        [XmlElementAttribute(Order = 10)]
        public bool IsAssisterUpdate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DCAgencyIndividualCaseAssociation : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayAttribute(Order = 0)]
        public DCAgencyIndividualCaseAssociationModel[] models { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DependentParamters : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string Key { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string Value { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ValidationParameter : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string Key { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string Value { get; set; }

        [XmlElementAttribute(Order = 2)]
        public YesNoType IsSuccessfullyExecuted { get; set; }

        [XmlElementAttribute("DependentParamter", IsNullable = true, Order = 3)]
        public DependentParamters[] DependentParamter { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualDetail : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute("AdditionalParameterToValidate", IsNullable = true, Order = 1)]
        public ValidationParameter[] AdditionalParameterToValidate { get; set; }

        [XmlElementAttribute(Order = 2)]
        public YesNoType IsSuccessfullyExecuted { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskDetails : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string TaskId { get; set; }

        [XmlElementAttribute("IndividualDetails", Order = 1)]
        public IndividualDetail[] IndividualDetails { get; set; }

        [XmlElementAttribute("AdditionalParameterToValidate", IsNullable = true, Order = 2)]
        public ValidationParameter[] AdditionalParameterToValidate { get; set; }

        [XmlElementAttribute(Order = 3)]
        public YesNoType IsSuccessfullyExecuted { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NewBornResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string Result { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ChildIndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string ErrorMessage { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SSPDCMessageType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public SSPDCMessageTypeMessageClassification messageClassification { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string activityDuration { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string messageKey { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string messageText { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string processId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ResponseType : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string transactionId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string lastExecutedTaskId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string lastExecutedActivityId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string runMode { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string sspApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string applicationNumber { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string OfficeId { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string caseNumber { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string documentId { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string transactionDuration { get; set; }

        [XmlElementAttribute("messages", Order = 10)]
        public SSPDCMessageType[] messages { get; set; }

        [XmlElementAttribute(Order = 11)]
        public NewBornResult NewBornResponse { get; set; }

        [XmlElementAttribute("RerunCheckList", Order = 12)]
        public TaskDetails[] RerunCheckList { get; set; }

        [XmlElementAttribute(Order = 13)]
        public object AdditionalMessage { get; set; }

        [XmlElementAttribute(Order = 14)]
        public int SSPDCProcessingID { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class PresumptiveHealthInusrancePolicyDetails : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string InsurancePlanName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string GroupId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string InsuranceCompanyName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string PolicyNumber { get; set; }
    }
    [XmlIncludeAttribute(typeof(HouseHoldSituation))]
    [XmlIncludeAttribute(typeof(ResourceQuestions))]
    [XmlIncludeAttribute(typeof(UserCaseAssociation))]
    [XmlIncludeAttribute(typeof(DSNAPDisasterQuestionDetails))]
    [XmlIncludeAttribute(typeof(DSNAPExpenseDetails))]
    [XmlIncludeAttribute(typeof(AlienSponsor))]
    [XmlIncludeAttribute(typeof(SponsoredIndividuals))]
    [XmlIncludeAttribute(typeof(ExpeditedSNAP))]
    [XmlIncludeAttribute(typeof(Conviction))]
    [XmlIncludeAttribute(typeof(Permission))]
    [XmlIncludeAttribute(typeof(Representative))]
    [XmlIncludeAttribute(typeof(NCPEmployerInformation))]
    [XmlIncludeAttribute(typeof(NonCustodialParent))]
    [XmlIncludeAttribute(typeof(NCPStatus))]
    [XmlIncludeAttribute(typeof(NCPJointCustody))]
    [XmlIncludeAttribute(typeof(NCPComplianceDetails))]
    [XmlIncludeAttribute(typeof(NonCustodialParentRelationship))]
    [XmlIncludeAttribute(typeof(NCPChildModel))]
    [XmlIncludeAttribute(typeof(RenewalESIgn))]
    [XmlIncludeAttribute(typeof(Individuals))]
    [XmlIncludeAttribute(typeof(RenewalPrograms))]
    [XmlIncludeAttribute(typeof(Renewals))]
    [XmlIncludeAttribute(typeof(CaseMerge))]
    [XmlIncludeAttribute(typeof(PreviousCaseDetails))]
    [XmlIncludeAttribute(typeof(APTCAnnualIncome))]
    [XmlIncludeAttribute(typeof(DSNAPResourceDetails))]
    [XmlIncludeAttribute(typeof(ExpenseQuestions))]
    [XmlIncludeAttribute(typeof(IncomeQuestions))]
    [XmlIncludeAttribute(typeof(InsuranceExternalPolicyHolder))]
    [XmlIncludeAttribute(typeof(InsurancePolicyDetail))]
    [XmlIncludeAttribute(typeof(InsuranceCoveredIndividual))]
    [XmlIncludeAttribute(typeof(ProgramIndividual))]
    [XmlIncludeAttribute(typeof(Program))]
    [XmlIncludeAttribute(typeof(WorkRequirementExemption))]
    [XmlIncludeAttribute(typeof(UnpaidEmploymentDetails))]
    [XmlIncludeAttribute(typeof(EducationExpense))]
    [XmlIncludeAttribute(typeof(DSNAPIncomeDetails))]
    [XmlIncludeAttribute(typeof(DSNAPEmployerAddressInformation))]
    [XmlIncludeAttribute(typeof(CareTakerService))]
    [XmlIncludeAttribute(typeof(CareCoordinator))]
    [XmlIncludeAttribute(typeof(CISInformation))]
    [XmlIncludeAttribute(typeof(EmergencyMedicalCondition))]
    [XmlIncludeAttribute(typeof(SSIBenefit))]
    [XmlIncludeAttribute(typeof(EntitledBenefits))]
    [XmlIncludeAttribute(typeof(EnrollmentSummary))]
    [XmlIncludeAttribute(typeof(IndividualEducation))]
    [XmlIncludeAttribute(typeof(DisabilityInformation))]
    [XmlIncludeAttribute(typeof(OutOfStateBenefits))]
    [XmlIncludeAttribute(typeof(LivingArrangement))]
    [XmlIncludeAttribute(typeof(TrustDetails))]
    [XmlIncludeAttribute(typeof(AnnuityDetails))]
    [XmlIncludeAttribute(typeof(RealEstatePropertyDetails))]
    [XmlIncludeAttribute(typeof(PreArrangedFuneralContractDetails))]
    [XmlIncludeAttribute(typeof(LifeInsuranceDetails))]
    [XmlIncludeAttribute(typeof(VehicleDetails))]
    [XmlIncludeAttribute(typeof(JointOwnersDetails))]
    [XmlIncludeAttribute(typeof(ResourceOwnership))]
    [XmlIncludeAttribute(typeof(LiquidAssetDetails))]
    [XmlIncludeAttribute(typeof(Resource))]
    [XmlIncludeAttribute(typeof(StatusOfTaxFiling))]
    [XmlIncludeAttribute(typeof(NonESIMec))]
    [XmlIncludeAttribute(typeof(ESIMec))]
    [XmlIncludeAttribute(typeof(S5B))]
    [XmlIncludeAttribute(typeof(VLP))]
    [XmlIncludeAttribute(typeof(SSA))]
    [XmlIncludeAttribute(typeof(ApplicationProgramIndividual))]
    [XmlIncludeAttribute(typeof(WaiverAssociation))]
    [XmlIncludeAttribute(typeof(BCCTPEligibility))]
    [XmlIncludeAttribute(typeof(MedicareDetails))]
    [XmlIncludeAttribute(typeof(Contact))]
    [XmlIncludeAttribute(typeof(Relationship))]
    [XmlIncludeAttribute(typeof(Pregnancy))]
    [XmlIncludeAttribute(typeof(MedicalCoverageLoss))]
    [XmlIncludeAttribute(typeof(PayPeriodInformation))]
    [XmlIncludeAttribute(typeof(VerifyCurrentIncome))]
    [XmlIncludeAttribute(typeof(Race))]
    [XmlIncludeAttribute(typeof(CoveredIndividual))]
    [XmlIncludeAttribute(typeof(MedicalCoverage))]
    [XmlIncludeAttribute(typeof(Incarceration))]
    [XmlIncludeAttribute(typeof(VerificationProofDocumentType))]
    [XmlIncludeAttribute(typeof(ApplicationVerificationResult))]
    [XmlIncludeAttribute(typeof(OtherIncomeDetail))]
    [XmlIncludeAttribute(typeof(UnearnedIncomeDetail))]
    [XmlIncludeAttribute(typeof(SelfEmploymentIncomeDetail))]
    [XmlIncludeAttribute(typeof(Expense))]
    [XmlIncludeAttribute(typeof(ESICoverageDetails))]
    [XmlIncludeAttribute(typeof(IncomePayDetail))]
    [XmlIncludeAttribute(typeof(EmploymentDetail))]
    [XmlIncludeAttribute(typeof(InsuranceCompany))]
    [XmlIncludeAttribute(typeof(ESICoveredIndividuals))]
    [XmlIncludeAttribute(typeof(EmploymentInfo))]
    [XmlIncludeAttribute(typeof(Address))]
    [XmlIncludeAttribute(typeof(Employer))]
    [XmlIncludeAttribute(typeof(PresumptiveEligibility))]
    [XmlIncludeAttribute(typeof(IndividualProfile))]
    [XmlIncludeAttribute(typeof(EmployerRosterDependent))]
    [XmlIncludeAttribute(typeof(EmployerRoster))]
    [XmlIncludeAttribute(typeof(Individual))]
    [XmlIncludeAttribute(typeof(ApplicationIndividual))]
    [XmlIncludeAttribute(typeof(AnnualIncomeDetails))]
    [XmlIncludeAttribute(typeof(TaskTypeComments))]
    [XmlIncludeAttribute(typeof(AdditionalInformation))]
    [XmlIncludeAttribute(typeof(ScreenCategoryMapping))]
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class controlInfo : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        protected System.Nullable<bool> _updateIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<bool> updateIndicator
        {
            get { return _updateIndicator; }
            set
            {
                _updateIndicator = value;
                updateIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool updateIndicatorSpecified { get; set; }

        protected System.Nullable<bool> _deleteIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<bool> deleteIndicator
        {
            get { return _deleteIndicator; }
            set
            {
                _deleteIndicator = value;
                deleteIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool deleteIndicatorSpecified { get; set; }

        protected System.Nullable<bool> _addIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<bool> addIndicator
        {
            get { return _addIndicator; }
            set
            {
                _addIndicator = value;
                addIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool addIndicatorSpecified { get; set; }

        protected System.Nullable<bool> _renewalRetainIndicator;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<bool> renewalRetainIndicator
        {
            get { return _renewalRetainIndicator; }
            set
            {
                _renewalRetainIndicator = value;
                renewalRetainIndicatorSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool renewalRetainIndicatorSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class HouseHoldSituation : controlInfo
    {
        protected System.Nullable<YesNoType> _IsAssetsInExcess1M;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> IsAssetsInExcess1M
        {
            get { return _IsAssetsInExcess1M; }
            set
            {
                _IsAssetsInExcess1M = value;
                IsAssetsInExcess1MSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsAssetsInExcess1MSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsReceivingHousingAssistance;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsReceivingHousingAssistance
        {
            get { return _IsReceivingHousingAssistance; }
            set
            {
                _IsReceivingHousingAssistance = value;
                IsReceivingHousingAssistanceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsReceivingHousingAssistanceSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ResourceQuestions : controlInfo
    {
        protected System.Nullable<YesNoType> _HasLiquidAsset;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> HasLiquidAsset
        {
            get { return _HasLiquidAsset; }
            set
            {
                _HasLiquidAsset = value;
                HasLiquidAssetSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLiquidAssetSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasVehicle;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> HasVehicle
        {
            get { return _HasVehicle; }
            set
            {
                _HasVehicle = value;
                HasVehicleSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasVehicleSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasLifeInsurance;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> HasLifeInsurance
        {
            get { return _HasLifeInsurance; }
            set
            {
                _HasLifeInsurance = value;
                HasLifeInsuranceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLifeInsuranceSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasPrearrangeFuneralAgreement;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> HasPrearrangeFuneralAgreement
        {
            get { return _HasPrearrangeFuneralAgreement; }
            set
            {
                _HasPrearrangeFuneralAgreement = value;
                HasPrearrangeFuneralAgreementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasPrearrangeFuneralAgreementSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasRealProperty;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> HasRealProperty
        {
            get { return _HasRealProperty; }
            set
            {
                _HasRealProperty = value;
                HasRealPropertySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasRealPropertySpecified { get; set; }

        protected System.Nullable<YesNoType> _HasAnnuity;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> HasAnnuity
        {
            get { return _HasAnnuity; }
            set
            {
                _HasAnnuity = value;
                HasAnnuitySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasAnnuitySpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSpecialNeedTrust;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> HasSpecialNeedTrust
        {
            get { return _HasSpecialNeedTrust; }
            set
            {
                _HasSpecialNeedTrust = value;
                HasSpecialNeedTrustSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSpecialNeedTrustSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBurialInsurance;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> HasBurialInsurance
        {
            get { return _HasBurialInsurance; }
            set
            {
                _HasBurialInsurance = value;
                HasBurialInsuranceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBurialInsuranceSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBurialFund;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> HasBurialFund
        {
            get { return _HasBurialFund; }
            set
            {
                _HasBurialFund = value;
                HasBurialFundSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBurialFundSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBurialPlot;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<YesNoType> HasBurialPlot
        {
            get { return _HasBurialPlot; }
            set
            {
                _HasBurialPlot = value;
                HasBurialPlotSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBurialPlotSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasPromisossoryNoteOrLandContract;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> HasPromisossoryNoteOrLandContract
        {
            get { return _HasPromisossoryNoteOrLandContract; }
            set
            {
                _HasPromisossoryNoteOrLandContract = value;
                HasPromisossoryNoteOrLandContractSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasPromisossoryNoteOrLandContractSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasOtherResources;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> HasOtherResources
        {
            get { return _HasOtherResources; }
            set
            {
                _HasOtherResources = value;
                HasOtherResourcesSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasOtherResourcesSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasLifeEstate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> HasLifeEstate
        {
            get { return _HasLifeEstate; }
            set
            {
                _HasLifeEstate = value;
                HasLifeEstateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLifeEstateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasLTCArrangement;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<YesNoType> HasLTCArrangement
        {
            get { return _HasLTCArrangement; }
            set
            {
                _HasLTCArrangement = value;
                HasLTCArrangementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLTCArrangementSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasPartnershipQualifiedLTCPolicy;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<YesNoType> HasPartnershipQualifiedLTCPolicy
        {
            get { return _HasPartnershipQualifiedLTCPolicy; }
            set
            {
                _HasPartnershipQualifiedLTCPolicy = value;
                HasPartnershipQualifiedLTCPolicySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasPartnershipQualifiedLTCPolicySpecified { get; set; }

        protected System.Nullable<YesNoType> _HasLifeSettlementContract;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<YesNoType> HasLifeSettlementContract
        {
            get { return _HasLifeSettlementContract; }
            set
            {
                _HasLifeSettlementContract = value;
                HasLifeSettlementContractSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLifeSettlementContractSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class UserCaseAssociation : controlInfo
    {
        protected System.Nullable<System.DateTime> _AssociationStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> AssociationStartDate
        {
            get { return _AssociationStartDate; }
            set
            {
                _AssociationStartDate = value;
                AssociationStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _AssociationEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> AssociationEndDate
        {
            get { return _AssociationEndDate; }
            set
            {
                _AssociationEndDate = value;
                AssociationEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationEndDateSpecified { get; set; }

        protected System.Nullable<int> _UserOrganizationId;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<int> UserOrganizationId
        {
            get { return _UserOrganizationId; }
            set
            {
                _UserOrganizationId = value;
                UserOrganizationIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool UserOrganizationIdSpecified { get; set; }

        protected System.Nullable<int> _UserId;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
                UserIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool UserIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string UserTypeCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DSNAPDisasterQuestionDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string HasAccessToCashOrCheckingDuringDisasterPeriod { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string HasIncurredDisasterRelatedExpense { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string HasPlanToPurchaseOrPrepareMealDuringDisasterPeriod { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string IsAnyoneFromHouseholdHaveIncome { get; set; }
        [XmlElementAttribute(Order = 4)]
        public string IsWorkingInDisasterAffectedArea { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DSNAPExpenseDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string FoodDestroyed { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string DependentCareExpenses { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string MedicalExpenses { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string FuneralExpenses { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string MovingStorageExpenses { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string TemporaryShelterExpenses { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string CostToProtectProperyDuringDisaster { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string CostToRepairAndReplace { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string OtherDisasterExpenses { get; set; }
        [XmlElementAttribute(Order = 9)]
        public decimal? CleanCostAmount { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class AlienSponsor : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int DCIndividualAlienSponsorId { get; set; }

        protected System.Nullable<int> _SponsorId;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> SponsorId
        {
            get { return _SponsorId; }
            set
            {
                _SponsorId = value;
                SponsorIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SponsorIdSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string SponsorFirstName { get; set; }

        [XmlElementAttribute("SponsoredIndividuals", Order = 3)]
        public SponsoredIndividuals[] SponsoredIndividuals { get; set; }

        protected System.Nullable<int> _AddressId;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<int> AddressId
        {
            get { return _AddressId; }
            set
            {
                _AddressId = value;
                AddressIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AddressIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string PrimaryPhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string Extension { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string PhoneType { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string AddressAttentionCareof { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string ZipCode5 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string CountyCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SponsoredIndividuals : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int DCIndividualAlienSponsorRelationshipId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string SponsorType { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ExpeditedSNAP : controlInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int ApplicationNumber { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string HasLessAmountinCashorSavings { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string HasLessGrossMonthlyIncomeAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IsHouseHoldShelterExpense { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public string IsDestituteFarmOrMigrantHousehold { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string HasIncomeStoppedBeforeApplying { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string IsIncomeReceivedFromSameSource { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string HasNewSourceOfIncome { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string HasIncomeMorethanTwentyFive { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public string IsPotentiallyEligibleForExpeditedSNAP { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public int DCSNAPHouseholdExpeditedScreeningId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Conviction : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public YesNoType IsFleeingFelonOrParoleViolator { get; set; }

        [XmlElementAttribute(Order = 1)]
        public YesNoType HasCompletedChemicalTreatment { get; set; }

        [XmlElementAttribute(Order = 2)]
        public YesNoType IsAssessedChemicallyDependent { get; set; }

        [XmlElementAttribute(Order = 3)]
        public YesNoType HasConvictedOfDrugFelony { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Permission : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string LevelOfPermissionCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Representative : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string FirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string MiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string LastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string SuffixName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> IsAuthorizedRepresentative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string OrganizationName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string OrgranizationIdentificationNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string PermissionLevelCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int RepresentativeId { get; set; }

        protected int _SSPRepresentativeId;

        [XmlElementAttribute(Order = 9)]
        public int SSPRepresentativeId
        {
            get { return _SSPRepresentativeId; }
            set
            {
                _SSPRepresentativeId = value;
                SSPRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPRepresentativeIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string RepresentativeRelationshipCode { get; set; }

        protected System.Nullable<System.DateTime> _AssociationStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> AssociationStartDate
        {
            get { return _AssociationStartDate; }
            set
            {
                _AssociationStartDate = value;
                AssociationStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _AssociationEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> AssociationEndDate
        {
            get { return _AssociationEndDate; }
            set
            {
                _AssociationEndDate = value;
                AssociationEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationEndDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsSignOnBehalf;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<YesNoType> IsSignOnBehalf
        {
            get { return _IsSignOnBehalf; }
            set
            {
                _IsSignOnBehalf = value;
                IsSignOnBehalfSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignOnBehalfSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsReceivedOnBehalf;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<YesNoType> IsReceivedOnBehalf
        {
            get { return _IsReceivedOnBehalf; }
            set
            {
                _IsReceivedOnBehalf = value;
                IsReceivedOnBehalfSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsReceivedOnBehalfSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsActOnBehalf;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<YesNoType> IsActOnBehalf
        {
            get { return _IsActOnBehalf; }
            set
            {
                _IsActOnBehalf = value;
                IsActOnBehalfSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsActOnBehalfSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsUpdateOnBehalf;

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<YesNoType> IsUpdateOnBehalf
        {
            get { return _IsUpdateOnBehalf; }
            set
            {
                _IsUpdateOnBehalf = value;
                IsUpdateOnBehalfSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUpdateOnBehalfSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string OrganizationTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 20)]
        public Address Address { get; set; }

        [XmlElementAttribute(Order = 21)]
        public Contact Contact { get; set; }

        [XmlElementAttribute("LevelOfPermissionModelList", Order = 22)]
        public Permission[] LevelOfPermissionModelList { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string GenderCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public System.Nullable<System.DateTime> BirthDate { get; set; }

        [XmlElementAttribute(Order = 25)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string Ssn { get; set; }

        protected System.Nullable<int> _ExternalOrganizationEmployeeId;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<int> ExternalOrganizationEmployeeId
        {
            get { return _ExternalOrganizationEmployeeId; }
            set
            {
                _ExternalOrganizationEmployeeId = value;
                ExternalOrganizationEmployeeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalOrganizationEmployeeIdSpecified { get; set; }

        protected System.Nullable<int> _ExternalOrganizationId;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<int> ExternalOrganizationId
        {
            get { return _ExternalOrganizationId; }
            set
            {
                _ExternalOrganizationId = value;
                ExternalOrganizationIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalOrganizationIdSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRepresentativeVerified;

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public System.Nullable<YesNoType> IsRepresentativeVerified
        {
            get { return _IsRepresentativeVerified; }
            set
            {
                _IsRepresentativeVerified = value;
                IsRepresentativeVerifiedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRepresentativeVerifiedSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 30)]
        public RepresentativeType[] RepresentativeTypes { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Address : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int AddressId { get; set; }

        protected int _SSPAddressId;

        [XmlElementAttribute(Order = 1)]
        public int SSPAddressId
        {
            get { return _SSPAddressId; }
            set
            {
                _SSPAddressId = value;
                SSPAddressIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPAddressIdSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string AddressTypeCode { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string City { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string ZipCode5 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string AddressAttentionCareof { get; set; }

        protected System.Nullable<YesNoType> _IsValidated;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsValidated
        {
            get { return _IsValidated; }
            set
            {
                _IsValidated = value;
                IsValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsValidatedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string RegionCode { get; set; }

        protected System.Nullable<System.DateTime> _DateOfMove;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> DateOfMove
        {
            get { return _DateOfMove; }
            set
            {
                _DateOfMove = value;
                DateOfMoveSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DateOfMoveSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string CertifiedNoStatIndicator { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string MailDeliveryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string ResidentialDeliveryIndicator { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string VacancyIndicator { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class InterimConversionDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string PersonNumber { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string InterimConversionStatus { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public int? ExtractAId { get; set; }

        [XmlElementAttribute(IsNullable = false, Order = 3)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 4)]
        public long? MciId { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string IsDhsConverted { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string IsBenefitMismatched { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string RequestedBy { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string IndividualDetails { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string PrimeNumber { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Contact : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int ContactId { get; set; }

        protected int _SSPContactId;

        [XmlElementAttribute(Order = 1)]
        public int SSPContactId
        {
            get { return _SSPContactId; }
            set
            {
                _SSPContactId = value;
                SSPContactIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPContactIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string PrimaryPhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string PrimaryPhoneTypeCode { get; set; }

        protected System.Nullable<int> _PrimaryPhoneExetnsion;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<int> PrimaryPhoneExetnsion
        {
            get { return _PrimaryPhoneExetnsion; }
            set
            {
                _PrimaryPhoneExetnsion = value;
                PrimaryPhoneExetnsionSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PrimaryPhoneExetnsionSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPrimaryVoicemailPreferred;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> IsPrimaryVoicemailPreferred
        {
            get { return _IsPrimaryVoicemailPreferred; }
            set
            {
                _IsPrimaryVoicemailPreferred = value;
                IsPrimaryVoicemailPreferredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPrimaryVoicemailPreferredSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPrimaryTextPreferred;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> IsPrimaryTextPreferred
        {
            get { return _IsPrimaryTextPreferred; }
            set
            {
                _IsPrimaryTextPreferred = value;
                IsPrimaryTextPreferredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPrimaryTextPreferredSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string SecondaryPhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string SecondaryPhoneTypeCode { get; set; }

        protected System.Nullable<int> _SecondaryPhoneExtension;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<int> SecondaryPhoneExtension
        {
            get { return _SecondaryPhoneExtension; }
            set
            {
                _SecondaryPhoneExtension = value;
                SecondaryPhoneExtensionSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SecondaryPhoneExtensionSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsSecondaryVoicemailPreferred;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> IsSecondaryVoicemailPreferred
        {
            get { return _IsSecondaryVoicemailPreferred; }
            set
            {
                _IsSecondaryVoicemailPreferred = value;
                IsSecondaryVoicemailPreferredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSecondaryVoicemailPreferredSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsSecondaryTextPreferred;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsSecondaryTextPreferred
        {
            get { return _IsSecondaryTextPreferred; }
            set
            {
                _IsSecondaryTextPreferred = value;
                IsSecondaryTextPreferredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSecondaryTextPreferredSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string PreferredContactMethodCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string PreferredNotificationMethodCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string Email { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string PreferedLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string PreferedBestTimeToContactCode { get; set; }

        protected System.Nullable<YesNoType> _IsPaperNotification;

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public System.Nullable<YesNoType> IsPaperNotification
        {
            get { return _IsPaperNotification; }
            set
            {
                _IsPaperNotification = value;
                IsPaperNotificationSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPaperNotificationSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string BestWayToContactDeafCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string PreferredSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string PreferredWrittenLanguageCode { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string PreferredTaxNotificationMethodCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string AlternateFormat { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string OtherSpokenLanguage { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string OtherWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEmailPreferred { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public string AuthorizeConsent { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string NeedInterpreter { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public string PreferBilingual { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public string AssistiveListeningDeviceNeeds { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public string COLanguageCode { get; set; }

        protected System.Nullable<YesNoType> _HasOptInForSMSReminders;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> HasOptInForSMSReminders
        {
            get { return _HasOptInForSMSReminders; }
            set
            {
                _HasOptInForSMSReminders = value;
                HasOptInForSMSRemindersSpecified = true;
            }
        }
        [XmlIgnoreAttribute]
        public bool HasOptInForSMSRemindersSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NCPEmployerInformation : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string CountryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string ZipCode5 { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NonCustodialParent : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int NonCustodialParentSequenceNumber { get; set; }

        protected int _SSPNonCustodialParentSequenceNumber;

        [XmlElementAttribute(Order = 1)]
        public int SSPNonCustodialParentSequenceNumber
        {
            get { return _SSPNonCustodialParentSequenceNumber; }
            set
            {
                _SSPNonCustodialParentSequenceNumber = value;
                SSPNonCustodialParentSequenceNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPNonCustodialParentSequenceNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string FirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string LastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string MiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string SuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string GenderCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string ParentSsn { get; set; }

        protected System.Nullable<System.DateTime> _ParentDateOfBirth;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> ParentDateOfBirth
        {
            get { return _ParentDateOfBirth; }
            set
            {
                _ParentDateOfBirth = value;
                ParentDateOfBirthSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ParentDateOfBirthSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string PlaceOfEmployment { get; set; }

        protected System.Nullable<YesNoType> _HasChildSupport;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> HasChildSupport
        {
            get { return _HasChildSupport; }
            set
            {
                _HasChildSupport = value;
                HasChildSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasChildSupportSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string CountryCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string ZipCode5 { get; set; }

        protected System.Nullable<YesNoType> _IsParentUnknown;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<YesNoType> IsParentUnknown
        {
            get { return _IsParentUnknown; }
            set
            {
                _IsParentUnknown = value;
                IsParentUnknownSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsParentUnknownSpecified { get; set; }

        [XmlElementAttribute(Order = 20)]
        public string IsAbsentParentParentsKnown { get; set; }

        [XmlElementAttribute(Order = 21)]
        public string IsAbsentParentEmploymentKnown { get; set; }

        [XmlElementAttribute(Order = 22)]
        public string HasCourtAction { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string IsMoneyReceivedFromAbsentParent { get; set; }

        [XmlElementAttribute(Order = 24)]
        public string HasIndividualLivedWithAbsentParent { get; set; }

        [XmlElementAttribute(Order = 25)]
        public string IsWillingForPaternity { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public NCPEmployerInformation NCPEmployerInformation { get; set; }

        [XmlElementAttribute("NonCustodialParentRelationship", IsNullable = true, Order = 27)]
        public NonCustodialParentRelationship[] NonCustodialParentRelationship { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 28)]
        public string AbsentParentTypeCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NonCustodialParentRelationship : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        protected System.Nullable<int> _ResponsibleIndividualID;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> ResponsibleIndividualID
        {
            get { return _ResponsibleIndividualID; }
            set
            {
                _ResponsibleIndividualID = value;
                ResponsibleIndividualIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResponsibleIndividualIDSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string StatusOnChildBirth { get; set; }

        protected System.Nullable<YesNoType> _HasChildSupport;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> HasChildSupport
        {
            get { return _HasChildSupport; }
            set
            {
                _HasChildSupport = value;
                HasChildSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasChildSupportSpecified { get; set; }

        [XmlElementAttribute("NCPComplianceDetails", Order = 4)]
        public NCPComplianceDetails[] NCPComplianceDetails { get; set; }

        [XmlElementAttribute("NCPJointCustody", Order = 5)]
        public NCPJointCustody[] NCPJointCustody { get; set; }

        [XmlElementAttribute("NCPStatus", Order = 6)]
        public NCPStatus[] NCPStatus { get; set; }

        //[XmlElementAttribute(Order = 7)]
        //public NonCustodialParent NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int NonCustodialParentSequenceNumber { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string IsHarmfulIfChildSupportPursued { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string AbsentParentFullName { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NCPComplianceDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string GoodCauseCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string NonCustodialParentStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string GoodCauseVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string Comments { get; set; }

        protected System.Nullable<YesNoType> _IsApplicantCooperative;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> IsApplicantCooperative
        {
            get { return _IsApplicantCooperative; }
            set
            {
                _IsApplicantCooperative = value;
                IsApplicantCooperativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsApplicantCooperativeSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NCPJointCustody : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string Is5050JointCustody { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string NonCustodialParentStatusCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NCPStatus : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string DesertationTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _DeathDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> DeathDate
        {
            get { return _DeathDate; }
            set
            {
                _DeathDate = value;
                DeathDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DeathDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IntendToReturnHome { get; set; }

        protected System.Nullable<System.DateTime> _ExpectedReleaseOrDischargeDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> ExpectedReleaseOrDischargeDate
        {
            get { return _ExpectedReleaseOrDischargeDate; }
            set
            {
                _ExpectedReleaseOrDischargeDate = value;
                ExpectedReleaseOrDischargeDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpectedReleaseOrDischargeDateSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NCPChildModel : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute("NonCustodialParentRelationship", Order = 1)]
        public NonCustodialParentRelationship[] NonCustodialParentRelationship { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class HouseholdQuestions : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string IsPregnant { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string HasOutOfStateBenefits { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IsReceivingOrAppliedForSSI { get; set; }

        [XmlElementAttribute(IsNullable = false, Order = 3)]
        public string HasEntitledBenefits { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string HasMedicare { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string HasPendingInjurySettlement { get; set; }
        [XmlElementAttribute(Order = 6)]
        public string IsFleeingFelonOrParoleViolator { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IsToBeReferredToWic { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class RenewalESIgn : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string ESignFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string ESignLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string ESignMiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string ESignSuffixCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Individuals : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public YesNoType IsCheckedForRenewal { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string Reason { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class RenewalPrograms : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string RenewalProgramCode { get; set; }

        [XmlElementAttribute("Individuals", Order = 1)]
        public Individuals[] Individuals { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Renewals : controlInfo
    {
        [XmlElementAttribute("RenewalPrograms", Order = 0)]
        public RenewalPrograms[] RenewalPrograms { get; set; }

        [XmlElementAttribute(Order = 1)]
        public RenewalESIgn RenewalESIgn { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CaseMerge : controlInfo
    {
        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class PreviousCaseDetails : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string NewCase { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public CaseMerge CaseMerge { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class APTCAnnualIncome : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int CoverageYear { get; set; }

        protected System.Nullable<decimal> _ProjectedAnnualIncome;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<decimal> ProjectedAnnualIncome
        {
            get { return _ProjectedAnnualIncome; }
            set
            {
                _ProjectedAnnualIncome = value;
                ProjectedAnnualIncomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ProjectedAnnualIncomeSpecified { get; set; }

        protected System.Nullable<decimal> _ReportedAnnualIncome;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<decimal> ReportedAnnualIncome
        {
            get { return _ReportedAnnualIncome; }
            set
            {
                _ReportedAnnualIncome = value;
                ReportedAnnualIncomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ReportedAnnualIncomeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string ReportedAnnualIncomeVerificationCode { get; set; }

        protected System.Nullable<System.DateTime> _ReportedAnnualIncomeVerificationDate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> ReportedAnnualIncomeVerificationDate
        {
            get { return _ReportedAnnualIncomeVerificationDate; }
            set
            {
                _ReportedAnnualIncomeVerificationDate = value;
                ReportedAnnualIncomeVerificationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ReportedAnnualIncomeVerificationDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string DifferenceReasonCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DSNAPResourceDetails : controlInfo
    {
        protected System.Nullable<decimal> _ResourceAmount;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<decimal> ResourceAmount
        {
            get { return _ResourceAmount; }
            set
            {
                _ResourceAmount = value;
                ResourceAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResourceAmountSpecified { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceType { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ExpenseQuestions : controlInfo
    {
        protected System.Nullable<YesNoType> _HasShelterExpense;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> HasShelterExpense
        {
            get { return _HasShelterExpense; }
            set
            {
                _HasShelterExpense = value;
                HasShelterExpenseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasShelterExpenseSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalExpense;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> HasMedicalExpense
        {
            get { return _HasMedicalExpense; }
            set
            {
                _HasMedicalExpense = value;
                HasMedicalExpenseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalExpenseSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasHouseholdPaidChildSupport;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> HasHouseholdPaidChildSupport
        {
            get { return _HasHouseholdPaidChildSupport; }
            set
            {
                _HasHouseholdPaidChildSupport = value;
                HasHouseholdPaidChildSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasHouseholdPaidChildSupportSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasDependentCare;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> HasDependentCare
        {
            get { return _HasDependentCare; }
            set
            {
                _HasDependentCare = value;
                HasDependentCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasDependentCareSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasHouseholdPaidAlimony;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> HasHouseholdPaidAlimony
        {
            get { return _HasHouseholdPaidAlimony; }
            set
            {
                _HasHouseholdPaidAlimony = value;
                HasHouseholdPaidAlimonySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasHouseholdPaidAlimonySpecified { get; set; }

        protected System.Nullable<YesNoType> _HasStudentLoanOrEducatorExpense;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> HasStudentLoanOrEducatorExpense
        {
            get { return _HasStudentLoanOrEducatorExpense; }
            set
            {
                _HasStudentLoanOrEducatorExpense = value;
                HasStudentLoanOrEducatorExpenseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasStudentLoanOrEducatorExpenseSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasUtilityExpense;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> HasUtilityExpense
        {
            get { return _HasUtilityExpense; }
            set
            {
                _HasUtilityExpense = value;
                HasUtilityExpenseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasUtilityExpenseSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasHouseholdDeductions;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> HasHouseholdDeductions
        {
            get { return _HasHouseholdDeductions; }
            set
            {
                _HasHouseholdDeductions = value;
                HasHouseholdDeductionsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasHouseholdDeductionsSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalExpensePartD;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> HasMedicalExpensePartD
        {
            get { return _HasMedicalExpensePartD; }
            set
            {
                _HasMedicalExpensePartD = value;
                HasMedicalExpensePartDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalExpensePartDSpecified { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<YesNoType> HasEducationExpenses { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public decimal? OutOfPocketAmount { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public YesNoType? HasPaidSpousalSupport { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string IsPrimarySource { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IncomeQuestions : controlInfo
    {
        protected System.Nullable<YesNoType> _HasEmploymentIncome;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> HasEmploymentIncome
        {
            get { return _HasEmploymentIncome; }
            set
            {
                _HasEmploymentIncome = value;
                HasEmploymentIncomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasEmploymentIncomeSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasUnearnedIncome;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> HasUnearnedIncome
        {
            get { return _HasUnearnedIncome; }
            set
            {
                _HasUnearnedIncome = value;
                HasUnearnedIncomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasUnearnedIncomeSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSelfEmploymentIncome;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> HasSelfEmploymentIncome
        {
            get { return _HasSelfEmploymentIncome; }
            set
            {
                _HasSelfEmploymentIncome = value;
                HasSelfEmploymentIncomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSelfEmploymentIncomeSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public YesNoType? HasUnpaidEmployment { get; set; }
        [XmlElement(IsNullable = true, Order = 4)]
        public YesNoType? HasSpecificIncome { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class InsuranceExternalPolicyHolder : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int InsuranceExternalPolicyHolderId { get; set; }

        protected int _SSPInsuranceExternalPolicyHolderId;

        [XmlElementAttribute(Order = 1)]
        public int SSPInsuranceExternalPolicyHolderId
        {
            get { return _SSPInsuranceExternalPolicyHolderId; }
            set
            {
                _SSPInsuranceExternalPolicyHolderId = value;
                SSPInsuranceExternalPolicyHolderIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPInsuranceExternalPolicyHolderIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string PolicyHolderFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string PolicyHolderLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PolicyHolderMiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string PolicyHolderSsn { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string PolicyHolderSuffixCode { get; set; }

        protected System.Nullable<int> _PolicyHolderDhsId;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> PolicyHolderDhsId
        {
            get { return _PolicyHolderDhsId; }
            set
            {
                _PolicyHolderDhsId = value;
                PolicyHolderDhsIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyHolderDhsIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PolicyHolderDateOfBirthDate;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> PolicyHolderDateOfBirthDate
        {
            get { return _PolicyHolderDateOfBirthDate; }
            set
            {
                _PolicyHolderDateOfBirthDate = value;
                PolicyHolderDateOfBirthDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyHolderDateOfBirthDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string ZipCode5 { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class InsurancePolicyDetail : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int InsurancePolicyDetailId { get; set; }

        protected int _SSPInsurancePolicyDetailId;

        [XmlElementAttribute(Order = 1)]
        public int SSPInsurancePolicyDetailId
        {
            get { return _SSPInsurancePolicyDetailId; }
            set
            {
                _SSPInsurancePolicyDetailId = value;
                SSPInsurancePolicyDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPInsurancePolicyDetailIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PolicyBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> PolicyBeginDate
        {
            get { return _PolicyBeginDate; }
            set
            {
                _PolicyBeginDate = value;
                PolicyBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PolicyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> PolicyEndDate
        {
            get { return _PolicyEndDate; }
            set
            {
                _PolicyEndDate = value;
                PolicyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string InsurancePolicyNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string InsuranceGroupNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string TypeOfCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string TypeOfFacility { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string PolicyVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string ReasonForLosingHealthCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string HasInsuranceCard { get; set; }

        [XmlElementAttribute(Order = 11)]
        public InsuranceCompany InsuranceCompany { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class InsuranceCompany : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int InsuranceCompanyId { get; set; }

        protected int _SSPInsuranceCompanyId;

        [XmlElementAttribute(Order = 1)]
        public int SSPInsuranceCompanyId
        {
            get { return _SSPInsuranceCompanyId; }
            set
            {
                _SSPInsuranceCompanyId = value;
                SSPInsuranceCompanyIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPInsuranceCompanyIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string InsuranceCompanyName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string InsuranceCompanyPhoneNumber { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string City { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string CountyCode { get; set; }

        [XmlElementAttribute(Order = 12)]
        public string ZipCode5 { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class InsuranceCoveredIndividual : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int CoveredIndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string RelationshipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IsRelatedIndividualPartOfCase { get; set; }

        protected System.Nullable<int> _InsuranceInternalPolicyHolderId;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> InsuranceInternalPolicyHolderId
        {
            get { return _InsuranceInternalPolicyHolderId; }
            set
            {
                _InsuranceInternalPolicyHolderId = value;
                InsuranceInternalPolicyHolderIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceInternalPolicyHolderIdSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public InsurancePolicyDetail InsurancePolicyDetail { get; set; }

        [XmlElementAttribute(Order = 5)]
        public InsuranceExternalPolicyHolder InsuranceExternalPolicyHolder { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ProgramIndividual : controlInfo
    {
        protected System.Nullable<YesNoType> _IsAidRequested;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> IsAidRequested
        {
            get { return _IsAidRequested; }
            set
            {
                _IsAidRequested = value;
                IsAidRequestedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsAidRequestedSpecified { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string IsPurchasingFoodTogether { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string IsUnableToPurchaseFoodSeparately { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Program : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute("ProgramIndividuals", Order = 1)]
        public ProgramIndividual[] ProgramIndividuals { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class WorkRequirementExemption : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int WorkRequirementExemptionId { get; set; }

        protected System.Nullable<YesNoType> _IsPhysicallyMentallyUnableToProvideCare;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsPhysicallyMentallyUnableToProvideCare
        {
            get { return _IsPhysicallyMentallyUnableToProvideCare; }
            set
            {
                _IsPhysicallyMentallyUnableToProvideCare = value;
                IsPhysicallyMentallyUnableToProvideCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhysicallyMentallyUnableToProvideCareSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsUnableToWorkandProvideCare;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsUnableToWorkandProvideCare
        {
            get { return _IsUnableToWorkandProvideCare; }
            set
            {
                _IsUnableToWorkandProvideCare = value;
                IsUnableToWorkandProvideCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUnableToWorkandProvideCareSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class UnpaidEmploymentDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int UnpaidEmploymentId { get; set; }

        protected System.Nullable<int> _HoursPerWeek;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> HoursPerWeek
        {
            get { return _HoursPerWeek; }
            set
            {
                _HoursPerWeek = value;
                HoursPerWeekSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HoursPerWeekSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.DateTime? ActivityStartDate { get; set; }

        protected System.Nullable<YesNoType> _IsRequiredForDegree;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsRequiredForDegree
        {
            get { return _IsRequiredForDegree; }
            set
            {
                _IsRequiredForDegree = value;
                IsRequiredForDegreeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRequiredForDegreeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRequiredToReceiveUIB;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> IsRequiredToReceiveUIB
        {
            get { return _IsRequiredToReceiveUIB; }
            set
            {
                _IsRequiredToReceiveUIB = value;
                IsRequiredToReceiveUIBSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRequiredToReceiveUIBSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string UnpaidEmploymentActivityCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public DateTime? ActivityEndDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public DateTime? DateOfChange { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string HasActivityStartedThreeMonthsPrior { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EducationExpense : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int EducationalExpenseId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public System.DateTime StartDate { get; set; }

        [XmlElementAttribute(Order = 2)]
        public System.DateTime EndDate { get; set; }

        protected System.Nullable<decimal> _TuitionAmount;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<decimal> TuitionAmount
        {
            get { return _TuitionAmount; }
            set
            {
                _TuitionAmount = value;
                TuitionAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TuitionAmountSpecified { get; set; }

        protected System.Nullable<decimal> _TransportationAmount;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<decimal> TransportationAmount
        {
            get { return _TransportationAmount; }
            set
            {
                _TransportationAmount = value;
                TransportationAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TransportationAmountSpecified { get; set; }

        protected System.Nullable<decimal> _MiscellaneousAmount;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<decimal> MiscellaneousAmount
        {
            get { return _MiscellaneousAmount; }
            set
            {
                _MiscellaneousAmount = value;
                MiscellaneousAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool MiscellaneousAmountSpecified { get; set; }

        protected System.Nullable<decimal> _FeesAmount;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<decimal> FeesAmount
        {
            get { return _FeesAmount; }
            set
            {
                _FeesAmount = value;
                FeesAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FeesAmountSpecified { get; set; }

        protected System.Nullable<decimal> _BooksAmount;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<decimal> BooksAmount
        {
            get { return _BooksAmount; }
            set
            {
                _BooksAmount = value;
                BooksAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BooksAmountSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DSNAPIncomeDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public decimal MonthlyNetAmount { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string IncomeType { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DSNAPEmployerAddressInformation : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int EmployerAddressId { get; set; }

        protected System.Nullable<int> _AffectedAreaWorkerIndividualId;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> AffectedAreaWorkerIndividualId
        {
            get { return _AffectedAreaWorkerIndividualId; }
            set
            {
                _AffectedAreaWorkerIndividualId = value;
                AffectedAreaWorkerIndividualIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AffectedAreaWorkerIndividualIdSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int AddressId { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string City { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string StateCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ZipCode4 { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string ZipCode5 { get; set; }

        [XmlElementAttribute(Order = 10)]
        public string CountyCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CareTakerService : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int CareTakerServiceId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public System.DateTime ServiceStartDate { get; set; }

        protected System.Nullable<System.DateTime> _ServiceEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> ServiceEndDate
        {
            get { return _ServiceEndDate; }
            set
            {
                _ServiceEndDate = value;
                ServiceEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ServiceEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public YesNoType IsServiceEnableToRemainSafe { get; set; }

        [XmlElementAttribute(Order = 5)]
        public YesNoType IsServicePreventFromInstitutionalization { get; set; }

        [XmlElementAttribute(Order = 6)]
        public YesNoType IsServiceProvidedAtRegularInterval { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string CareTakerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string CareTakerPhoneNumber { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CareCoordinator : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int DCIndividualCommunityIntegrationSupplementationId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int CareCoordinatorId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string Name { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string CareCoordinatorCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PrimaryPhoneNumber { get; set; }

        protected System.Nullable<int> _PrimaryPhoneExtension;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> PrimaryPhoneExtension
        {
            get { return _PrimaryPhoneExtension; }
            set
            {
                _PrimaryPhoneExtension = value;
                PrimaryPhoneExtensionSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PrimaryPhoneExtensionSpecified { get; set; }

        [XmlElementAttribute(Order = 6)]
        public Address Address { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int ContactID { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CISInformation : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int DCIndividualCommunityIntegrationSupplementationId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> CISStartDate { get; set; }

        protected System.Nullable<System.DateTime> _CISEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> CISEndDate
        {
            get { return _CISEndDate; }
            set
            {
                _CISEndDate = value;
                CISEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CISEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public YesNoType IsMentalIllnessImpairingFunctioning { get; set; }

        [XmlElementAttribute(Order = 4)]
        public YesNoType IsMentalIllnessNeedingTreatment { get; set; }

        [XmlElementAttribute(Order = 5)]
        public YesNoType IsMentalIllnessNotIncludingAlzheimer { get; set; }

        [XmlElementAttribute(Order = 6)]
        public YesNoType IsServicePreventingInstitutionalization { get; set; }

        [XmlElementAttribute(Order = 7)]
        public CareCoordinator CareCoordinator { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EmergencyMedicalCondition : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int EmergencyMedicalConditionId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public System.DateTime EmergencyBeginDate { get; set; }

        protected System.Nullable<System.DateTime> _EmergencyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> EmergencyEndDate
        {
            get { return _EmergencyEndDate; }
            set
            {
                _EmergencyEndDate = value;
                EmergencyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmergencyEndDateSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SSIBenefit : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int SSIBenefitId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string BenefitStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> BenefitApplicationDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public DateTime? DenialAppealDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EntitledBenefits : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int EntitledBenefitId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string BenefitTypeCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int? ResponsiblePartyIndividualId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EnrollmentSummary : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> ExpectedGraduationDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string SchoolName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string InstitutionSchoolTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string EnrollmentTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PlacedThroughProgramCode { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int EducationEnrollmentId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<int> SchoolId { get; set; }

        protected System.Nullable<int> _HoursPerWeek;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> HoursPerWeek
        {
            get { return _HoursPerWeek; }
            set
            {
                _HoursPerWeek = value;
                HoursPerWeekSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HoursPerWeekSpecified { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string IsOnlineCourse { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public string HaveAwardedFederalWork { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public string HaveAssignedCurrentSemester { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public string HasRefusedAssignment { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public string IsParticipatinginWorkStudy { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public string IsChildCareRequired { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public string IsAssignedToInstitutionThroughProgram { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public string IsUndergraduateProgram { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public string IsEligibleWorkStudy { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public string UndergradEmployment { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public string ExpectedFamilyContribution { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualEducation : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string HighestEducationLevelCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> GraduationDate { get; set; }

        [XmlElementAttribute("EnrollmentSummary", Order = 2)]
        public EnrollmentSummary[] EnrollmentSummary { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int EducationId { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int AttendanceId { get; set; }
        [XmlElementAttribute(Order = 5)]
        public string IsCurrentlyEnrolledInSchool { get; set; }
        [XmlElementAttribute(Order = 6)]
        public string HasStoppedAttendingSchool { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class DisabilityInformation : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int DisabilityId { get; set; }

        protected System.Nullable<YesNoType> _IsDisabled;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsDisabled
        {
            get { return _IsDisabled; }
            set
            {
                _IsDisabled = value;
                IsDisabledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDisabledSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsBlind;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsBlind
        {
            get { return _IsBlind; }
            set
            {
                _IsBlind = value;
                IsBlindSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsBlindSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsOnSickLeave { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> RecoveryDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> ReturnToWorkDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string HasAnyBenefitDueToDisability { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class OutOfStateBenefits : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string BenefitProgram { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string SelectedState { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string BenefitInfoCounty { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int OutOfStateBenefitReceivedId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public DateTime? BenefitFromDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public DateTime? BenefitToDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string TribeName { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class LivingArrangement : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int LivingArrangementId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int ProviderId { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int LivingArrangementHospitalizationId { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string LaTypeCode { get; set; }

        protected System.Nullable<YesNoType> _HasRecievedHalfMealsFrmInst;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> HasRecievedHalfMealsFrmInst
        {
            get { return _HasRecievedHalfMealsFrmInst; }
            set
            {
                _HasRecievedHalfMealsFrmInst = value;
                HasRecievedHalfMealsFrmInstSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasRecievedHalfMealsFrmInstSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ConvictedDate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> ConvictedDate
        {
            get { return _ConvictedDate; }
            set
            {
                _ConvictedDate = value;
                ConvictedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ConvictedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpectedReturnDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ExpectedReturnDate
        {
            get { return _ExpectedReturnDate; }
            set
            {
                _ExpectedReturnDate = value;
                ExpectedReturnDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpectedReturnDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ProviderName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string IncarcerationStatusTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _HospitalizationBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<System.DateTime> HospitalizationBeginDate
        {
            get { return _HospitalizationBeginDate; }
            set
            {
                _HospitalizationBeginDate = value;
                HospitalizationBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HospitalizationBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _HospitalizationEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> HospitalizationEndDate
        {
            get { return _HospitalizationEndDate; }
            set
            {
                _HospitalizationEndDate = value;
                HospitalizationEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HospitalizationEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 11)]
        public string IsReceivingCISDueToMentalIllness { get; set; }

        [XmlElementAttribute(Order = 12)]
        public string IsReceivingCaretakerServiceToPreventInstitutionalization { get; set; }
        [XmlElementAttribute(Order = 13)]
        public string IsHospitalized { get; set; }

        [XmlElementAttribute(Order = 14)]
        public string IsExpectedToReturn { get; set; }
        [XmlElementAttribute(Order = 15)]
        public string IsOutOfHomeTemporarily { get; set; }
        [XmlElementAttribute(Order = 16)]
        public string IsRequiredToApplyForSnap { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public DateTime? ReleaseDate { get; set; }
        [XmlElement(IsNullable = true, Order = 18)]
        public DateTime? IndividualLivingArrangementStartDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string IsDormitoryOnCampus { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string HasMealPlan { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string Has50PercentFromMealPlan { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public int? DCLivingArrangementProviderId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string IsIndividualHomeless { get; set; }


    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TrustDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _ResourceStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> ResourceStartDate
        {
            get { return _ResourceStartDate; }
            set
            {
                _ResourceStartDate = value;
                ResourceStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResourceStartDateSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public decimal TrustResourceAmount { get; set; }

        protected System.Nullable<System.DateTime> _ResourceEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> ResourceEndDate
        {
            get { return _ResourceEndDate; }
            set
            {
                _ResourceEndDate = value;
                ResourceEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResourceEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string OwnershipEndReason { get; set; }

        [XmlElementAttribute(Order = 6)]
        public ResourceOwnership ResourceOwnership { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string NotEnoughInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public ResourceTrustIndividual[] ResourceTrustGrantorbeneficiaryList { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public DateTime? DateOfChange { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ResourceOwnership : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int ResourceId { get; set; }

        [XmlElementAttribute("JointOwnersDetails", Order = 1)]
        public JointOwnersDetails[] JointOwnersDetails { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int ResourceOwnershipDetailId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class JointOwnersDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int JointOwnerIndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string JointOwnerFirstName { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string JointOwnerMiddleName { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string JointOwnerLastName { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int ResourceOwnershipDetailId { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int JointOwnerDetailID { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class AnnuityDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _AnnuitizedDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> AnnuitizedDate
        {
            get { return _AnnuitizedDate; }
            set
            {
                _AnnuitizedDate = value;
                AnnuitizedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuitizedDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _AnnuityIsQualified;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> AnnuityIsQualified
        {
            get { return _AnnuityIsQualified; }
            set
            {
                _AnnuityIsQualified = value;
                AnnuityIsQualifiedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuityIsQualifiedSpecified { get; set; }

        protected System.Nullable<YesNoType> _AnnuityIsLiquidated;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> AnnuityIsLiquidated
        {
            get { return _AnnuityIsLiquidated; }
            set
            {
                _AnnuityIsLiquidated = value;
                AnnuityIsLiquidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuityIsLiquidatedSpecified { get; set; }

        protected System.Nullable<System.DateTime> _AnnuityExpectedReturnTimeframe;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> AnnuityExpectedReturnTimeframe
        {
            get { return _AnnuityExpectedReturnTimeframe; }
            set
            {
                _AnnuityExpectedReturnTimeframe = value;
                AnnuityExpectedReturnTimeframeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuityExpectedReturnTimeframeSpecified { get; set; }

        protected System.Nullable<YesNoType> _AnnuityIsProvidingEqualPayment;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> AnnuityIsProvidingEqualPayment
        {
            get { return _AnnuityIsProvidingEqualPayment; }
            set
            {
                _AnnuityIsProvidingEqualPayment = value;
                AnnuityIsProvidingEqualPaymentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuityIsProvidingEqualPaymentSpecified { get; set; }

        protected System.Nullable<YesNoType> _AnnuityHasDeferredPayment;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> AnnuityHasDeferredPayment
        {
            get { return _AnnuityHasDeferredPayment; }
            set
            {
                _AnnuityHasDeferredPayment = value;
                AnnuityHasDeferredPaymentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AnnuityHasDeferredPaymentSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 8)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string NotEnoughInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public DateTime? EndDate { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public DateTime? DateOfChange { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class RealEstatePropertyDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected decimal _FairMarketValue;

        [XmlElementAttribute(Order = 2)]
        public decimal FairMarketValue
        {
            get { return _FairMarketValue; }
            set
            {
                _FairMarketValue = value;
                FairMarketValueSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FairMarketValueSpecified { get; set; }

        protected decimal _LoanBalance;

        [XmlElementAttribute(Order = 3)]
        public decimal LoanBalance
        {
            get { return _LoanBalance; }
            set
            {
                _LoanBalance = value;
                LoanBalanceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LoanBalanceSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string Description { get; set; }

        [XmlElementAttribute(Order = 5)]
        public ResourceOwnership ResourceOwnership { get; set; }

        protected System.Nullable<YesNoType> _RealPropertyIsThisHomesteadProperty;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> RealPropertyIsThisHomesteadProperty
        {
            get { return _RealPropertyIsThisHomesteadProperty; }
            set
            {
                _RealPropertyIsThisHomesteadProperty = value;
                RealPropertyIsThisHomesteadPropertySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool RealPropertyIsThisHomesteadPropertySpecified { get; set; }

        protected System.Nullable<YesNoType> _RealPropertyDoesSpouseStayInProperty;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> RealPropertyDoesSpouseStayInProperty
        {
            get { return _RealPropertyDoesSpouseStayInProperty; }
            set
            {
                _RealPropertyDoesSpouseStayInProperty = value;
                RealPropertyDoesSpouseStayInPropertySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool RealPropertyDoesSpouseStayInPropertySpecified { get; set; }

        protected System.Nullable<YesNoType> _RealPropertyDoesDependentStayInProperty;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> RealPropertyDoesDependentStayInProperty
        {
            get { return _RealPropertyDoesDependentStayInProperty; }
            set
            {
                _RealPropertyDoesDependentStayInProperty = value;
                RealPropertyDoesDependentStayInPropertySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool RealPropertyDoesDependentStayInPropertySpecified { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 11)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 12)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string NotEnoughInformation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public DateTime? DateOfChange { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public DateTime? EndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class PreArrangedFuneralContractDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected decimal _PreFuneralAgreementGoodsAndServicesCost;

        [XmlElementAttribute(Order = 2)]
        public decimal PreFuneralAgreementGoodsAndServicesCost
        {
            get { return _PreFuneralAgreementGoodsAndServicesCost; }
            set
            {
                _PreFuneralAgreementGoodsAndServicesCost = value;
                PreFuneralAgreementGoodsAndServicesCostSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PreFuneralAgreementGoodsAndServicesCostSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string PreFuneralAgreementFuneralLocation { get; set; }

        protected System.Nullable<YesNoType> _PreFuneralAgreementHasItemizedGoodsSignedByClient;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> PreFuneralAgreementHasItemizedGoodsSignedByClient
        {
            get { return _PreFuneralAgreementHasItemizedGoodsSignedByClient; }
            set
            {
                _PreFuneralAgreementHasItemizedGoodsSignedByClient = value;
                PreFuneralAgreementHasItemizedGoodsSignedByClientSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PreFuneralAgreementHasItemizedGoodsSignedByClientSpecified { get; set; }

        protected System.Nullable<YesNoType> _PreFuneralAgreementHasItemizedGoodsSignedByFuneralHome;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> PreFuneralAgreementHasItemizedGoodsSignedByFuneralHome
        {
            get { return _PreFuneralAgreementHasItemizedGoodsSignedByFuneralHome; }
            set
            {
                _PreFuneralAgreementHasItemizedGoodsSignedByFuneralHome = value;
                PreFuneralAgreementHasItemizedGoodsSignedByFuneralHomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PreFuneralAgreementHasItemizedGoodsSignedByFuneralHomeSpecified { get; set; }

        [XmlElementAttribute(Order = 6)]
        public string FuneralAddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string FuneralAddressLine2 { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string FuneralCity { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string FuneralStateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string FuneralZipCode { get; set; }

        [XmlElementAttribute(Order = 11)]
        public string FuneralInsurancePolicyCode { get; set; }

        protected System.Nullable<YesNoType> _LifeInsuranceIsPolicyUsedToFundPreFuneralContract;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> LifeInsuranceIsPolicyUsedToFundPreFuneralContract
        {
            get { return _LifeInsuranceIsPolicyUsedToFundPreFuneralContract; }
            set
            {
                _LifeInsuranceIsPolicyUsedToFundPreFuneralContract = value;
                LifeInsuranceIsPolicyUsedToFundPreFuneralContractSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LifeInsuranceIsPolicyUsedToFundPreFuneralContractSpecified { get; set; }

        [XmlElementAttribute(Order = 13)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 14)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 15)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 16)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string NotEnoughInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public DateTime? DateOfChange { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public DateTime? EndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class LifeInsuranceDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected decimal _FairMarketValue;

        [XmlElementAttribute(Order = 2)]
        public decimal FairMarketValue
        {
            get { return _FairMarketValue; }
            set
            {
                _FairMarketValue = value;
                FairMarketValueSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FairMarketValueSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string LifeInsurancePolicyNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string LifeInsuranceCompanyName { get; set; }

        [XmlElementAttribute(Order = 5)]
        public System.DateTime? ResourceStartDate { get; set; }

        protected decimal _LoanBalance;

        [XmlElementAttribute(Order = 6)]
        public decimal LoanBalance
        {
            get { return _LoanBalance; }
            set
            {
                _LoanBalance = value;
                LoanBalanceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LoanBalanceSpecified { get; set; }

        protected System.Nullable<YesNoType> _LifeInsuranceIsPolicyDesignatedToPayBurial;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> LifeInsuranceIsPolicyDesignatedToPayBurial
        {
            get { return _LifeInsuranceIsPolicyDesignatedToPayBurial; }
            set
            {
                _LifeInsuranceIsPolicyDesignatedToPayBurial = value;
                LifeInsuranceIsPolicyDesignatedToPayBurialSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LifeInsuranceIsPolicyDesignatedToPayBurialSpecified { get; set; }

        protected System.Nullable<YesNoType> _LifeInsuranceIsPolicyUsedToFundPreFuneralContract;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> LifeInsuranceIsPolicyUsedToFundPreFuneralContract
        {
            get { return _LifeInsuranceIsPolicyUsedToFundPreFuneralContract; }
            set
            {
                _LifeInsuranceIsPolicyUsedToFundPreFuneralContract = value;
                LifeInsuranceIsPolicyUsedToFundPreFuneralContractSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LifeInsuranceIsPolicyUsedToFundPreFuneralContractSpecified { get; set; }

        [XmlElementAttribute(Order = 9)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 11)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 12)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string NotEnoughInformation { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public decimal? CashSurrenderValue { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public DateTime? DateOfChange { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public DateTime? EndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class VehicleDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected decimal _FairMarketValue;

        [XmlElementAttribute(Order = 2)]
        public decimal FairMarketValue
        {
            get { return _FairMarketValue; }
            set
            {
                _FairMarketValue = value;
                FairMarketValueSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FairMarketValueSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string VehicleCategoryCode { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string VehicleMake { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string VehicleModel { get; set; }

        [XmlElementAttribute(Order = 6)]
        public int VehicleModelYear { get; set; }

        protected System.Nullable<System.DateTime> _ResourceStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> ResourceStartDate
        {
            get { return _ResourceStartDate; }
            set
            {
                _ResourceStartDate = value;
                ResourceStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResourceStartDateSpecified { get; set; }

        protected decimal _Debt;

        [XmlElementAttribute(Order = 8)]
        public decimal Debt
        {
            get { return _Debt; }
            set
            {
                _Debt = value;
                DebtSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DebtSpecified { get; set; }

        [XmlElementAttribute(Order = 9)]
        public ResourceOwnership ResourceOwnership { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 11)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 12)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 13)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string NotEnoughInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public DateTime? DateOfChange { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public DateTime? EndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class LiquidAssetDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string ResourceTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string ResourceSubTypeCode { get; set; }

        protected decimal _FairMarketValue;

        [XmlElementAttribute(Order = 2)]
        public decimal FairMarketValue
        {
            get { return _FairMarketValue; }
            set
            {
                _FairMarketValue = value;
                FairMarketValueSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FairMarketValueSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public ResourceOwnership ResourceOwnership { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int ResourceId { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int ResourceDetailId { get; set; }

        [XmlElementAttribute(Order = 6)]
        public int ResourceMiscellaneousDetailId { get; set; }

        [XmlElementAttribute(Order = 7)]
        public int ResourceValueDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string NotEnoughInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public DateTime? DateOfChange { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public DateTime? EndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Resource : controlInfo
    {
        [XmlElementAttribute("LiquidAssetDetails", Order = 0)]
        public LiquidAssetDetails[] LiquidAssetDetails { get; set; }

        [XmlElementAttribute("VehicleDetails", Order = 1)]
        public VehicleDetails[] VehicleDetails { get; set; }

        [XmlElementAttribute("LifeInsuranceDetails", Order = 2)]
        public LifeInsuranceDetails[] LifeInsuranceDetails { get; set; }

        [XmlElementAttribute("PreArrangedFuneralContractDetails", Order = 3)]
        public PreArrangedFuneralContractDetails[] PreArrangedFuneralContractDetails { get; set; }

        [XmlElementAttribute("RealEstatePropertyDetails", Order = 4)]
        public RealEstatePropertyDetails[] RealEstatePropertyDetails { get; set; }

        [XmlElementAttribute("AnnuityDetails", Order = 5)]
        public AnnuityDetails[] AnnuityDetails { get; set; }

        [XmlElementAttribute("TrustDetails", Order = 6)]
        public TrustDetails[] TrustDetails { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class StatusOfTaxFiling : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int TaxFilingYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string TaxStatusCode { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int StatusofTaxFilingId { get; set; }

        protected System.Nullable<int> _Dependent;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> Dependent
        {
            get { return _Dependent; }
            set
            {
                _Dependent = value;
                DependentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DependentSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public YesNoType? ClaimingParentOrSibling { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class NonESIMec : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string OrganizationCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string MECVerificationCode { get; set; }

        protected System.Nullable<System.DateTime> _InsuranceEffectiveDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> InsuranceEffectiveDate
        {
            get { return _InsuranceEffectiveDate; }
            set
            {
                _InsuranceEffectiveDate = value;
                InsuranceEffectiveDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceEffectiveDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _InsuranceEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> InsuranceEndDate
        {
            get { return _InsuranceEndDate; }
            set
            {
                _InsuranceEndDate = value;
                InsuranceEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceEndDateSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ESIMec : controlInfo
    {
        protected System.Nullable<YesNoType> _IsApplicantInsured;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> IsApplicantInsured
        {
            get { return _IsApplicantInsured; }
            set
            {
                _IsApplicantInsured = value;
                IsApplicantInsuredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsApplicantInsuredSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEmployerSponsoredInsurance;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsEmployerSponsoredInsurance
        {
            get { return _IsEmployerSponsoredInsurance; }
            set
            {
                _IsEmployerSponsoredInsurance = value;
                IsEmployerSponsoredInsuranceSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEmployerSponsoredInsuranceSpecified { get; set; }

        protected System.Nullable<System.DateTime> _InsurancePolicyEffectiveDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> InsurancePolicyEffectiveDate
        {
            get { return _InsurancePolicyEffectiveDate; }
            set
            {
                _InsurancePolicyEffectiveDate = value;
                InsurancePolicyEffectiveDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsurancePolicyEffectiveDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _InsurancePolicyExpirationDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> InsurancePolicyExpirationDate
        {
            get { return _InsurancePolicyExpirationDate; }
            set
            {
                _InsurancePolicyExpirationDate = value;
                InsurancePolicyExpirationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsurancePolicyExpirationDateSpecified { get; set; }

        protected System.Nullable<decimal> _EmployeePremiumAmount;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<decimal> EmployeePremiumAmount
        {
            get { return _EmployeePremiumAmount; }
            set
            {
                _EmployeePremiumAmount = value;
                EmployeePremiumAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmployeePremiumAmountSpecified { get; set; }

        protected System.Nullable<decimal> _FamilyPremiumAmount;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<decimal> FamilyPremiumAmount
        {
            get { return _FamilyPremiumAmount; }
            set
            {
                _FamilyPremiumAmount = value;
                FamilyPremiumAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FamilyPremiumAmountSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class S5B : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public string EmployerId { get; set; }

        protected System.Nullable<decimal> _LowestPlanPreimumAmount;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<decimal> LowestPlanPreimumAmount
        {
            get { return _LowestPlanPreimumAmount; }
            set
            {
                _LowestPlanPreimumAmount = value;
                LowestPlanPreimumAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LowestPlanPreimumAmountSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPlanOffered;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsPlanOffered
        {
            get { return _IsPlanOffered; }
            set
            {
                _IsPlanOffered = value;
                IsPlanOfferedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPlanOfferedSpecified { get; set; }

        protected System.Nullable<int> _PlanIssuerId;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> PlanIssuerId
        {
            get { return _PlanIssuerId; }
            set
            {
                _PlanIssuerId = value;
                PlanIssuerIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PlanIssuerIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PlanIssuerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string PlanName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string PlanType { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class VLP : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string IsVerifiedLawfulPresence { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string EligibilityStatementCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IsFiveYearBar { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IsFiveYearBarMet { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string NonCitizenClassOfAdmissionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string IsQualifiedNonCitizen { get; set; }

        protected System.Nullable<System.DateTime> _NonCitizenEntryDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> NonCitizenEntryDate
        {
            get { return _NonCitizenEntryDate; }
            set
            {
                _NonCitizenEntryDate = value;
                NonCitizenEntryDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool NonCitizenEntryDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string CaseNbr { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string UsCitizenCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string NonCitizenLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string NonCitizenFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string NonCitizenMiddleName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> NonCitizenBirthDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> NonCitizenAdmittedToDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string EligibilityStatementText { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> GrantDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string AgencyAction { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string IavTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string IavTypeText { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<System.DateTime> EADSExpirationDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ResponseCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ResponseDescriptionText { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string NextStep { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string CurrentVLPStep { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string NonCitizenCountryBirthCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string NonCitizenCountryOfCitizenshipCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SSA : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string Ssn { get; set; }

        protected System.Nullable<YesNoType> _IsDateOfDeathValidated;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsDateOfDeathValidated
        {
            get { return _IsDateOfDeathValidated; }
            set
            {
                _IsDateOfDeathValidated = value;
                IsDateOfDeathValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDateOfDeathValidatedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsUsCitizenValidated;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsUsCitizenValidated
        {
            get { return _IsUsCitizenValidated; }
            set
            {
                _IsUsCitizenValidated = value;
                IsUsCitizenValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsCitizenValidatedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsSsnValidated;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsSsnValidated
        {
            get { return _IsSsnValidated; }
            set
            {
                _IsSsnValidated = value;
                IsSsnValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSsnValidatedSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasFederalIncarcerationInformation;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> HasFederalIncarcerationInformation
        {
            get { return _HasFederalIncarcerationInformation; }
            set
            {
                _HasFederalIncarcerationInformation = value;
                HasFederalIncarcerationInformationSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasFederalIncarcerationInformationSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsInmate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> IsInmate
        {
            get { return _IsInmate; }
            set
            {
                _IsInmate = value;
                IsInmateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsInmateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PrisonerConfinementDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> PrisonerConfinementDate
        {
            get { return _PrisonerConfinementDate; }
            set
            {
                _PrisonerConfinementDate = value;
                PrisonerConfinementDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PrisonerConfinementDateSpecified { get; set; }

        protected System.Nullable<int> _LifeTimeQuarterQuantity;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> LifeTimeQuarterQuantity
        {
            get { return _LifeTimeQuarterQuantity; }
            set
            {
                _LifeTimeQuarterQuantity = value;
                LifeTimeQuarterQuantitySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LifeTimeQuarterQuantitySpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string SSNVerificationCode { get; set; }

        protected System.Nullable<YesNoType> _IsDateOfBirthValidated;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<YesNoType> IsDateOfBirthValidated
        {
            get { return _IsDateOfBirthValidated; }
            set
            {
                _IsDateOfBirthValidated = value;
                IsDateOfBirthValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDateOfBirthValidatedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string DeathDateVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string CitizenshipVerificationCode { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ApplicationProgramIndividual : controlInfo
    {
        protected System.Nullable<System.DateTime> _RequestDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> RequestDate
        {
            get { return _RequestDate; }
            set
            {
                _RequestDate = value;
                RequestDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool RequestDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsAidRequested;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsAidRequested
        {
            get { return _IsAidRequested; }
            set
            {
                _IsAidRequested = value;
                IsAidRequestedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsAidRequestedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string MedicaidFormCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string ProgramStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string CoverageCode { get; set; }

        protected System.Nullable<int> _MemberId;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> MemberId
        {
            get { return _MemberId; }
            set
            {
                _MemberId = value;
                MemberIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool MemberIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LostHealthCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> LostHealthCoverageDate
        {
            get { return _LostHealthCoverageDate; }
            set
            {
                _LostHealthCoverageDate = value;
                LostHealthCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LostHealthCoverageDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string CoverageLostCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string CoverageLostReasonCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class WaiverAssociation : controlInfo
    {
        protected System.Nullable<int> _OrganizationEmployeeId;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> OrganizationEmployeeId
        {
            get { return _OrganizationEmployeeId; }
            set
            {
                _OrganizationEmployeeId = value;
                OrganizationEmployeeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OrganizationEmployeeIdSpecified { get; set; }

        protected System.Nullable<int> _UserId;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
                UserIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool UserIdSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class BCCTPEligibility : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public System.DateTime BenefitBeginDate { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int IndividualID { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string PresumptiveRole { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IsIncarcerated { get; set; }

        [XmlElementAttribute(Order = 4)]
        public System.DateTime effectiveBeginDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> EffectiveEndDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string HasGotBenefitsThisCalendarYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string InsurancePlanName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string InsuranceCompanyname { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string Policynumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string GroupID { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string IsKYWCSP { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string BCCTPTypecode { get; set; }

        [XmlElementAttribute("PresumptiveHealthInusrancePolicyDetails", IsNullable = true, Order = 13)]
        public PresumptiveHealthInusrancePolicyDetails[] PresumptiveHealthInusrancePolicyDetails { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string HasOtherInsurance { get; set; }

        [XmlElementAttribute(Order = 15)]
        public string CreateEntityCode { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string CreateUserID { get; set; }

        [XmlElementAttribute(Order = 17)]
        public System.DateTime Createdate { get; set; }

        [XmlElementAttribute(Order = 18)]
        public string UpdateUserID { get; set; }

        [XmlElementAttribute(Order = 19)]
        public int Casenumber { get; set; }

        [XmlElementAttribute(Order = 20)]
        public System.DateTime BenefitEndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class MedicareDetails : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string TypeOfCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string InsurancePolicyNumber { get; set; }

        protected System.Nullable<System.DateTime> _PolicyBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> PolicyBeginDate
        {
            get { return _PolicyBeginDate; }
            set
            {
                _PolicyBeginDate = value;
                PolicyBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PolicyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> PolicyEndDate
        {
            get { return _PolicyEndDate; }
            set
            {
                _PolicyEndDate = value;
                PolicyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int HealthInsurancePolicyDetailId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Relationship : controlInfo
    {
        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string RelationshipTypeCode { get; set; }

        protected System.Nullable<YesNoType> _IsPrepareAndPurchases;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsPrepareAndPurchases
        {
            get { return _IsPrepareAndPurchases; }
            set
            {
                _IsPrepareAndPurchases = value;
                IsPrepareAndPurchasesSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPrepareAndPurchasesSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasFilledParentalRole;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> HasFilledParentalRole
        {
            get { return _HasFilledParentalRole; }
            set
            {
                _HasFilledParentalRole = value;
                HasFilledParentalRoleSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasFilledParentalRoleSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string RelationshipVerificationCode { get; set; }

        protected System.Nullable<YesNoType> _HasProvidedCareFor;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> HasProvidedCareFor
        {
            get { return _HasProvidedCareFor; }
            set
            {
                _HasProvidedCareFor = value;
                HasProvidedCareForSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasProvidedCareForSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhysicallyAbleToPurchasePrepare;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> IsPhysicallyAbleToPurchasePrepare
        {
            get { return _IsPhysicallyAbleToPurchasePrepare; }
            set
            {
                _IsPhysicallyAbleToPurchasePrepare = value;
                IsPhysicallyAbleToPurchasePrepareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhysicallyAbleToPurchasePrepareSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsProvidingSupportFor;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> IsProvidingSupportFor
        {
            get { return _IsProvidingSupportFor; }
            set
            {
                _IsProvidingSupportFor = value;
                IsProvidingSupportForSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsProvidingSupportForSpecified { get; set; }

        protected System.Nullable<System.DateTime> _MarriageDate;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<System.DateTime> MarriageDate
        {
            get { return _MarriageDate; }
            set
            {
                _MarriageDate = value;
                MarriageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool MarriageDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _VerificationRecievedDate;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> VerificationRecievedDate
        {
            get { return _VerificationRecievedDate; }
            set
            {
                _VerificationRecievedDate = value;
                VerificationRecievedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VerificationRecievedDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsAdopted;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsAdopted
        {
            get { return _IsAdopted; }
            set
            {
                _IsAdopted = value;
                IsAdoptedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsAdoptedSpecified { get; set; }

        protected System.Nullable<System.DateTime> _AdoptionDate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> AdoptionDate
        {
            get { return _AdoptionDate; }
            set
            {
                _AdoptionDate = value;
                AdoptionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AdoptionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string LastYearTaxStatusCode { get; set; }

        [XmlElementAttribute(Order = 14)]
        public int RelatedIndividualId { get; set; }

        [XmlElementAttribute(Order = 15)]
        public int RelationshipSequenceNumber { get; set; }

        protected int _SSPRelationshipSequenceNumber;

        [XmlElementAttribute(Order = 16)]
        public int SSPRelationshipSequenceNumber
        {
            get { return _SSPRelationshipSequenceNumber; }
            set
            {
                _SSPRelationshipSequenceNumber = value;
                SSPRelationshipSequenceNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPRelationshipSequenceNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string CurrentYearTaxStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string IsCaretaker { get; set; }

        protected System.Nullable<YesNoType> _IsActingParent;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<YesNoType> IsActingParent
        {
            get { return _IsActingParent; }
            set
            {
                _IsActingParent = value;
                IsActingParentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsActingParentSpecified { get; set; }

        protected System.Nullable<YesNoType> _IntendToPursueLegalCustody;

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<YesNoType> IntendToPursueLegalCustody
        {
            get { return _IntendToPursueLegalCustody; }
            set
            {
                _IntendToPursueLegalCustody = value;
                IntendToPursueLegalCustodySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IntendToPursueLegalCustodySpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 21)]
        public YesNoType? IsPurchasingAndPreparingTogether { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 22)]
        public YesNoType? IsCaringandSupervising { get; set; }
        [XmlElement(IsNullable = true, Order = 23)]
        public string IsLegalGuardian { get; set; }
        [XmlElement(IsNullable = true, Order = 24)]
        public string IsPrimaryCaretaker { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Pregnancy : controlInfo
    {
        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _DueDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> DueDate
        {
            get { return _DueDate; }
            set
            {
                _DueDate = value;
                DueDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DueDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _TerminationDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> TerminationDate
        {
            get { return _TerminationDate; }
            set
            {
                _TerminationDate = value;
                TerminationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TerminationDateSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public byte NumberOfBirthsExpected { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PregnancyVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string ExemptForWorkingCode { get; set; }

        protected System.Nullable<System.DateTime> _VerificationRecievedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> VerificationRecievedDate
        {
            get { return _VerificationRecievedDate; }
            set
            {
                _VerificationRecievedDate = value;
                VerificationRecievedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VerificationRecievedDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsProblemPregnancy;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> IsProblemPregnancy
        {
            get { return _IsProblemPregnancy; }
            set
            {
                _IsProblemPregnancy = value;
                IsProblemPregnancySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsProblemPregnancySpecified { get; set; }

        protected System.Nullable<System.DateTime> _PregnancyBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> PregnancyBeginDate
        {
            get { return _PregnancyBeginDate; }
            set
            {
                _PregnancyBeginDate = value;
                PregnancyBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PregnancyBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PregnancyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<System.DateTime> PregnancyEndDate
        {
            get { return _PregnancyEndDate; }
            set
            {
                _PregnancyEndDate = value;
                PregnancyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PregnancyEndDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPregnantEndIRecentPast;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> IsPregnantEndIRecentPast
        {
            get { return _IsPregnantEndIRecentPast; }
            set
            {
                _IsPregnantEndIRecentPast = value;
                IsPregnantEndIRecentPastSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPregnantEndIRecentPastSpecified { get; set; }

        [XmlElementAttribute(Order = 11)]
        public int PregnancyId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string PregnancyNonHouseholdMemberName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public int? OtherParentIndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public DateTime? DateReported { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class MedicalCoverageLoss : controlInfo
    {
        protected System.Nullable<System.DateTime> _CoverageLostDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> CoverageLostDate
        {
            get { return _CoverageLostDate; }
            set
            {
                _CoverageLostDate = value;
                CoverageLostDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageLostDateSpecified { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string CoverageLostTypeCode { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string CoverageLostReasonCode { get; set; }

        protected int _SSPIndividualMedicalCoverageLossSequenceNumber;

        [XmlElementAttribute(Order = 3)]
        public int SSPIndividualMedicalCoverageLossSequenceNumber
        {
            get { return _SSPIndividualMedicalCoverageLossSequenceNumber; }
            set
            {
                _SSPIndividualMedicalCoverageLossSequenceNumber = value;
                SSPIndividualMedicalCoverageLossSequenceNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPIndividualMedicalCoverageLossSequenceNumberSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int IndividualMedicalCoverageLossId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class PayPeriodInformation : controlInfo
    {
        protected System.Nullable<System.DateTime> _PayPeriodEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> PayPeriodEndDate
        {
            get { return _PayPeriodEndDate; }
            set
            {
                _PayPeriodEndDate = value;
                PayPeriodEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PayPeriodEndDateSpecified { get; set; }

        protected System.Nullable<decimal> _PayPeriodIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<decimal> PayPeriodIncomeAmount
        {
            get { return _PayPeriodIncomeAmount; }
            set
            {
                _PayPeriodIncomeAmount = value;
                PayPeriodIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PayPeriodIncomeAmountSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class VerifyCurrentIncome : controlInfo
    {
        [XmlElementAttribute("PayPeriodInformation", Order = 0)]
        public PayPeriodInformation[] PayPeriodInformation { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int VerifyCurrentIncomeId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string Ssn { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string FirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string LastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string MiddleInitial { get; set; }

        protected System.Nullable<System.DateTime> _BirthDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> BirthDate
        {
            get { return _BirthDate; }
            set
            {
                _BirthDate = value;
                BirthDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BirthDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(Order = 8)]
        public long Ein { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string EmployeeStatusCode { get; set; }

        protected System.Nullable<System.DateTime> _AssociationBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> AssociationBeginDate
        {
            get { return _AssociationBeginDate; }
            set
            {
                _AssociationBeginDate = value;
                AssociationBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _AssociationEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> AssociationEndDate
        {
            get { return _AssociationEndDate; }
            set
            {
                _AssociationEndDate = value;
                AssociationEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AssociationEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string PayPeriodFrequencyCode { get; set; }

        protected System.Nullable<decimal> _AnnualizedIncome;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<decimal> AnnualizedIncome
        {
            get { return _AnnualizedIncome; }
            set
            {
                _AnnualizedIncome = value;
                AnnualizedIncomeSpecified = true;
            }
        }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string PayFrequencyCode { get; set; }
        [XmlIgnoreAttribute]
        public bool AnnualizedIncomeSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class Race : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int IndividualRaceId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string RaceCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OtherRaceCode { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class Nationality : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string NationalityCode { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class IndividualGenderIdentity : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int? IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TypeCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string IdentifierType { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class TribalLandDetail : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int? IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int TribalLandDetailId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string IsAnyoneResidingOnTribalLand { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string HasIndianAllotmentNotTrustHeld { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string TribalLandCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string OtherTribalLandName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string IndianAllotmentName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public DateTime? BeginDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public DateTime? EndDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string VerificationCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public int? DCTribalLandDetailId { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class IndividualLanguage : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string LanguageCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string LanguageReferenceCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string OtherHomeLanguage { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string IdentifierTypeCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string COLanguageCode { get; set; }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class Ethinicity : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string EthinicityCode { get; set; }

    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CoveredIndividual : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int CoveredIndividualId { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string RelationshipCode { get; set; }

        [XmlElementAttribute(Order = 2)]
        public int HealthInsurancePolicyDetailId { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int HealthInsuranceCoveredIndividualsDetailId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public string[] SelectedReasonCodes { get; set; }

        [XmlElementAttribute(Order = 5)]
        public System.Nullable<System.DateTime> CoverageStartDate { get; set; }

        [XmlElementAttribute(Order = 6)]
        public System.Nullable<System.DateTime> CoverageEndDate { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class MedicalCoverage : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string TypeOfCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string InsurancePolicyNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string InsuranceGroupNumber { get; set; }

        protected System.Nullable<System.DateTime> _PolicyBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> PolicyBeginDate
        {
            get { return _PolicyBeginDate; }
            set
            {
                _PolicyBeginDate = value;
                PolicyBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyBeginDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string InsuranceCompanyName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string Zipcode5 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string City { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string StateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string Zipcode4 { get; set; }

        protected System.Nullable<System.DateTime> _PolicyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> PolicyEndDate
        {
            get { return _PolicyEndDate; }
            set
            {
                _PolicyEndDate = value;
                PolicyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<int> PolicyHolderId { get; set; }

        [XmlElementAttribute("CoveredIndividual", Order = 13)]
        public CoveredIndividual[] CoveredIndividual { get; set; }

        [XmlElementAttribute(Order = 14)]
        public int HealthInsurancePolicyDetailId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string PolicyHolderFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string PolicyHolderLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string PolicyHolderMiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string PolicyHolderSuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string IsPolicyHolderMemberOfCase { get; set; }

        protected System.Nullable<int> _InsuranceExternalPolicyHolderId;

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<int> InsuranceExternalPolicyHolderId
        {
            get { return _InsuranceExternalPolicyHolderId; }
            set
            {
                _InsuranceExternalPolicyHolderId = value;
                InsuranceExternalPolicyHolderIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceExternalPolicyHolderIdSpecified { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public DateTime? PolicyHolderDateOfBirthDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ReasonForLosingHealthCoverageCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string IsAnyoneUnableToUseInsurance { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string InsuranceCompanyPhoneNumber { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Incarceration : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IncarcerationId { get; set; }

        protected System.Nullable<System.DateTime> _IncarcerationBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> IncarcerationBeginDate
        {
            get { return _IncarcerationBeginDate; }
            set
            {
                _IncarcerationBeginDate = value;
                IncarcerationBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IncarcerationBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _IncarcerationEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> IncarcerationEndDate
        {
            get { return _IncarcerationEndDate; }
            set
            {
                _IncarcerationEndDate = value;
                IncarcerationEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IncarcerationEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IncarcerationStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string IncarcerationVerificationCode { get; set; }

        [XmlElementAttribute(Order = 5)]
        public int HistorySequenceId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class VerificationProofDocumentType : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int VerificationProofDocumentTypeId { get; set; }

        protected int _SSPVerificationProofDocumentTypeId;

        [XmlElementAttribute(Order = 1)]
        public int SSPVerificationProofDocumentTypeId
        {
            get { return _SSPVerificationProofDocumentTypeId; }
            set
            {
                _SSPVerificationProofDocumentTypeId = value;
                SSPVerificationProofDocumentTypeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPVerificationProofDocumentTypeIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string DocumentTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string ReceivedFileLocation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string DocumentName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string Comment { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string VerificationStatusCode { get; set; }

        protected System.Nullable<System.DateTime> _VerificationDate;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> VerificationDate
        {
            get { return _VerificationDate; }
            set
            {
                _VerificationDate = value;
                VerificationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VerificationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EffectiveStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> EffectiveStartDate
        {
            get { return _EffectiveStartDate; }
            set
            {
                _EffectiveStartDate = value;
                EffectiveStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EffectiveStartDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string VerificationTypeCode { get; set; }

        [XmlElementAttribute(Order = 10)]
        public int IndividualApplicationVerificationResultId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ApplicationVerificationResult : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int IndividualApplicationVerificationResultId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string VerificationResult { get; set; }

        protected System.Nullable<System.DateTime> _EffectiveStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> EffectiveStartDate
        {
            get { return _EffectiveStartDate; }
            set
            {
                _EffectiveStartDate = value;
                EffectiveStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EffectiveStartDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string RequiredProofIndicator { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string ProofSubmissionTypeCode { get; set; }

        protected System.Nullable<System.DateTime> _NeededDate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> NeededDate
        {
            get { return _NeededDate; }
            set
            {
                _NeededDate = value;
                NeededDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool NeededDateSpecified { get; set; }

        [XmlElementAttribute("VerificationProofDocumentType", Order = 6)]
        public VerificationProofDocumentType[] VerificationProofDocumentType { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class OtherIncomeDetail : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int OtherIncomeDetailId { get; set; }

        protected int _SSPOtherIncomeDetailId;

        [XmlElementAttribute(Order = 1)]
        public int SSPOtherIncomeDetailId
        {
            get { return _SSPOtherIncomeDetailId; }
            set
            {
                _SSPOtherIncomeDetailId = value;
                SSPOtherIncomeDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPOtherIncomeDetailIdSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string OtherEarnedIncomeTypeCode { get; set; }

        protected System.Nullable<YesNoType> _IsOtherEarnedIncomeVerified;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsOtherEarnedIncomeVerified
        {
            get { return _IsOtherEarnedIncomeVerified; }
            set
            {
                _IsOtherEarnedIncomeVerified = value;
                IsOtherEarnedIncomeVerifiedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsOtherEarnedIncomeVerifiedSpecified { get; set; }

        [XmlElementAttribute(Order = 4)]
        public IncomePayDetail IncomePayDetail { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IncomePayDetail : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string IncomePayTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string EorUIncomeType { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string PayIndicator { get; set; }

        protected System.Nullable<YesNoType> _IsPayForPartialAmount;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsPayForPartialAmount
        {
            get { return _IsPayForPartialAmount; }
            set
            {
                _IsPayForPartialAmount = value;
                IsPayForPartialAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPayForPartialAmountSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PayFrequency { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string LastMonthForIncome { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string PayVerificationCode { get; set; }

        protected System.Nullable<System.DateTime> _PayDate;
        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> PayDate
        {
            get { return _PayDate; }
            set
            {
                _PayDate = value;
                PayDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PayDateSpecified { get; set; }

        protected System.Nullable<int> _HoursPaidFor;
        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<int> HoursPaidFor
        {
            get { return _HoursPaidFor; }
            set
            {
                _HoursPaidFor = value;
                HoursPaidForSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HoursPaidForSpecified { get; set; }

        protected System.Nullable<decimal> _GrossPaymentAmount;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<decimal> GrossPaymentAmount
        {
            get { return _GrossPaymentAmount; }
            set
            {
                _GrossPaymentAmount = value;
                GrossPaymentAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossPaymentAmountSpecified { get; set; }

        protected System.Nullable<decimal> _OtherPayAmount;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<decimal> OtherPayAmount
        {
            get { return _OtherPayAmount; }
            set
            {
                _OtherPayAmount = value;
                OtherPayAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OtherPayAmountSpecified { get; set; }

        protected System.Nullable<decimal> _ExcludedPayAmount;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<decimal> ExcludedPayAmount
        {
            get { return _ExcludedPayAmount; }
            set
            {
                _ExcludedPayAmount = value;
                ExcludedPayAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExcludedPayAmountSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string ExcludedPayReasonCode { get; set; }

        [XmlElementAttribute(Order = 13)]
        public decimal TotalGrossAmount { get; set; }

        protected System.Nullable<YesNoType> _IncludeInProjections;
        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<YesNoType> IncludeInProjections
        {
            get { return _IncludeInProjections; }
            set
            {
                _IncludeInProjections = value;
                IncludeInProjectionsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IncludeInProjectionsSpecified { get; set; }

        protected System.Nullable<byte> _NumberOfMonthsIntended;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<byte> NumberOfMonthsIntended
        {
            get { return _NumberOfMonthsIntended; }
            set
            {
                _NumberOfMonthsIntended = value;
                NumberOfMonthsIntendedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool NumberOfMonthsIntendedSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public int IncomePayDetailId { get; set; }

        protected int _SSPIncomePayDetailId;

        [XmlElementAttribute(Order = 17)]
        public int SSPIncomePayDetailId
        {
            get { return _SSPIncomePayDetailId; }
            set
            {
                _SSPIncomePayDetailId = value;
                SSPIncomePayDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPIncomePayDetailIdSpecified { get; set; }

        protected System.Nullable<decimal> _GrossUnearnedIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<decimal> GrossUnearnedIncomeAmount
        {
            get { return _GrossUnearnedIncomeAmount; }
            set
            {
                _GrossUnearnedIncomeAmount = value;
                GrossUnearnedIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossUnearnedIncomeAmountSpecified { get; set; }

        protected System.Nullable<decimal> _TipsPerFrequency;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<decimal> TipsPerFrequency
        {
            get { return _TipsPerFrequency; }
            set
            {
                _TipsPerFrequency = value;
                TipsPerFrequencySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TipsPerFrequencySpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public int? UnearnedIncomePayAssociationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 21)]
        public int? EmploymentDetailPayAssociationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 22)]
        public int? SelfEmploymentDetailPayAssociationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 23)]
        public decimal? HoursPerWeek { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 24)]
        public string DayOfTheWeekPaid { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 25)]
        public int? DaysPerMonth { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 26)]
        public decimal? ExpenseAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 27)]
        public int? SpecificIncomeDetailPayAssociationId { get; set; }
        [XmlElement(IsNullable = true, Order = 28)]
        public decimal? ScheduleAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 29)]
        public decimal? LifeInsuranceInterestAmount { get; set; }

        [XmlElement(IsNullable = true, Order = 30)]
        public decimal? TaxableScholarshipAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 31)]
        public decimal? StartMonthActualAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 32)]
        public decimal? EndMonthActualAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 33)]
        public decimal? StartMonthScheduleAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 34)]
        public decimal? EndMonthScheduleAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 35)]
        public decimal? StartMonthExpenseAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 36)]
        public decimal? EndMonthExpenseAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 37)]
        public decimal? StartMonthLifeInsuranceInterestAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 38)]
        public decimal? EndMonthLifeInsuranceInterestAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 39)]
        public decimal? StartMonthActualHours { get; set; }
        [XmlElement(IsNullable = true, Order = 40)]
        public decimal? EndMonthActualHours { get; set; }


        [XmlElement(IsNullable = true, Order = 41)]
        public decimal? StartMonthDisabilityTaxableAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 42)]
        public decimal? StartMonthUSDATotalAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 43)]
        public decimal? StartMonthPremiumAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 44)]
        public decimal? StartMonthAmountPaidToAttendant { get; set; }
        [XmlElement(IsNullable = true, Order = 45)]
        public decimal? StartMonthPenaltyAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 46)]
        public decimal? StartMonthActiveServiceAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 47)]
        public decimal? StartMonthCashMedicalSupportAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 48)]
        public decimal? StartMonthGIBillDeductionAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 49)]
        public decimal? StartMonthCombatPayAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 50)]
        public decimal? StartMonthNetPayAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 51)]
        public decimal? StartMonthChildCareAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 52)]
        public decimal? StartMonthRoomAndBoardAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 53)]
        public decimal? EndMonthDisabilityTaxableAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 54)]
        public decimal? EndMonthUSDATotalAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 55)]
        public decimal? EndMonthPremiumAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 56)]
        public decimal? EndMonthAmountPaidToAttendant { get; set; }
        [XmlElement(IsNullable = true, Order = 57)]
        public decimal? EndMonthPenaltyAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 58)]
        public decimal? EndMonthActiveServiceAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 59)]
        public decimal? EndMonthCashMedicalSupportAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 60)]
        public decimal? EndMonthGIBillDeductionAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 61)]
        public decimal? EndMonthCombatPayAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 62)]
        public decimal? EndMonthNetPayAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 63)]
        public decimal? EndMonthChildCareAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 64)]
        public decimal? EndMonthRoomAndBoardAmount { get; set; }
        [XmlElement(IsNullable = true, Order = 65)]
        public DateTime? IncomeFromDate { get; set; }
        [XmlElement(IsNullable = true, Order = 66)]
        public string HasEmploymentStartedThreeMonthsPrior { get; set; }
        [XmlElement(IsNullable = true, Order = 67)]
        public System.Nullable<System.DateTime> IncomeStartDateOnIncomeChange { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class UnearnedIncomeDetail : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int UnearnedIncomeDetailId { get; set; }

        protected int _SSPUnearnedIncomeDetailId;

        [XmlElementAttribute(Order = 1)]
        public int SSPUnearnedIncomeDetailId
        {
            get { return _SSPUnearnedIncomeDetailId; }
            set
            {
                _SSPUnearnedIncomeDetailId = value;
                SSPUnearnedIncomeDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPUnearnedIncomeDetailIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string UnearnedIncomeTypeCode { get; set; }

        protected System.Nullable<YesNoType> _IsUnearnedIncomeVerified;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> IsUnearnedIncomeVerified
        {
            get { return _IsUnearnedIncomeVerified; }
            set
            {
                _IsUnearnedIncomeVerified = value;
                IsUnearnedIncomeVerifiedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUnearnedIncomeVerifiedSpecified { get; set; }

        [XmlElementAttribute(Order = 5)]
        public IncomePayDetail IncomePayDetail { get; set; }

        protected System.Nullable<System.DateTime> _UnearnedIncomeStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> UnearnedIncomeStartDate
        {
            get { return _UnearnedIncomeStartDate; }
            set
            {
                _UnearnedIncomeStartDate = value;
                UnearnedIncomeStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool UnearnedIncomeStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _UnearnedIncomeEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> UnearnedIncomeEndDate
        {
            get { return _UnearnedIncomeEndDate; }
            set
            {
                _UnearnedIncomeEndDate = value;
                UnearnedIncomeEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool UnearnedIncomeEndDateSpecified { get; set; }
        [XmlElement(IsNullable = true, Order = 8)]
        public DateTime? DateOfChange { get; set; }
        [XmlElement(IsNullable = true, Order = 9)]
        public string IncomeCategoryCode { get; set; }
        [XmlElement(IsNullable = true, Order = 10)]
        public DateTime? FirstPayDate { get; set; }
        [XmlElement(IsNullable = true, Order = 11)]
        public DateTime? FinalPayDate { get; set; }
        [XmlElement(IsNullable = true, Order = 12)]
        public string IsGiftCard { get; set; }
        [XmlElement(IsNullable = true, Order = 13)]
        public string IsGiftCardForFood { get; set; }
        [XmlElement(IsNullable = true, Order = 14)]
        public string AttendingProgramCode { get; set; }
        [XmlElement(IsNullable = true, Order = 15)]
        public string IsReceivedAsMoney { get; set; }
        [XmlElement(IsNullable = true, Order = 16)]
        public string HasAnyBenefitDueToDisability { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SelfEmploymentIncomeDetail : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int SelfEmploymentIncomeDetailId { get; set; }

        protected int _SSPSelfEmploymentIncomeDetailId;

        [XmlElementAttribute(Order = 1)]
        public int SSPSelfEmploymentIncomeDetailId
        {
            get { return _SSPSelfEmploymentIncomeDetailId; }
            set
            {
                _SSPSelfEmploymentIncomeDetailId = value;
                SSPSelfEmploymentIncomeDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPSelfEmploymentIncomeDetailIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _SelfEmploymentStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> SelfEmploymentStartDate
        {
            get { return _SelfEmploymentStartDate; }
            set
            {
                _SelfEmploymentStartDate = value;
                SelfEmploymentStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SelfEmploymentStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _SelfEmploymentEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> SelfEmploymentEndDate
        {
            get { return _SelfEmploymentEndDate; }
            set
            {
                _SelfEmploymentEndDate = value;
                SelfEmploymentEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SelfEmploymentEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string BusinessTitle { get; set; }

        protected System.Nullable<decimal> _ExpensesAmount;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<decimal> ExpensesAmount
        {
            get { return _ExpensesAmount; }
            set
            {
                _ExpensesAmount = value;
                ExpensesAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpensesAmountSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string ExpenseVerificationCode { get; set; }

        [XmlElementAttribute(Order = 9)]
        public IncomePayDetail IncomePayDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string BusinessType { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public DateTime? DateOfChange { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public DateTime? FirstPayDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string IncomeCategoryCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 14)]

        public string PaymentCoveredIndividualId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public int? PaymentMadeByIndividualId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string IsTemporarilyOnLeave { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string LeaveReasonCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public DateTime? ExpectedDateOfReturn { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public DateTime? LastPayDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public DateTime? TemporaryLeaveDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string IsTemporarilyOnLeaveDueToSickChild { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public int? ChildIndividualId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Expense : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string ExpenseTypeCode { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int ExpenseDetailId { get; set; }

        protected int _SSPExpenseId;

        [XmlElementAttribute(Order = 2)]
        public int SSPExpenseId
        {
            get { return _SSPExpenseId; }
            set
            {
                _SSPExpenseId = value;
                SSPExpenseIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPExpenseIdSpecified { get; set; }

        protected System.Nullable<decimal> _ExpenseAmount;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<decimal> ExpenseAmount
        {
            get { return _ExpenseAmount; }
            set
            {
                _ExpenseAmount = value;
                ExpenseAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpenseAmountSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string ExpenseFrequencyCode { get; set; }

        protected System.Nullable<decimal> _ExpenseMonthlyAmount;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<decimal> ExpenseMonthlyAmount
        {
            get { return _ExpenseMonthlyAmount; }
            set
            {
                _ExpenseMonthlyAmount = value;
                ExpenseMonthlyAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpenseMonthlyAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpenseIncurredDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ExpenseIncurredDate
        {
            get { return _ExpenseIncurredDate; }
            set
            {
                _ExpenseIncurredDate = value;
                ExpenseIncurredDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpenseIncurredDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string ExpenseSubType { get; set; }

        protected System.Nullable<YesNoType> _IsExpenseRecurring;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> IsExpenseRecurring
        {
            get { return _IsExpenseRecurring; }
            set
            {
                _IsExpenseRecurring = value;
                IsExpenseRecurringSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpenseRecurringSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string PaidForNonMemberName { get; set; }

        protected int _PaidForIndividualId;

        [XmlElementAttribute(Order = 10)]
        public int PaidForIndividualId
        {
            get { return _PaidForIndividualId; }
            set
            {
                _PaidForIndividualId = value;
                PaidForIndividualIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PaidForIndividualIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpenseStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> ExpenseStartDate
        {
            get { return _ExpenseStartDate; }
            set
            {
                _ExpenseStartDate = value;
                ExpenseStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpenseStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpenseEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> ExpenseEndDate
        {
            get { return _ExpenseEndDate; }
            set
            {
                _ExpenseEndDate = value;
                ExpenseEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpenseEndDateSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public decimal? ChildCareAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public decimal? RentalorPurchaseAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public decimal? InsurancePremiumAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public decimal? LoanOriginatorAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public decimal? TuitionAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public decimal? TransportationAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public decimal? MiscellaneousAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public decimal? FeesAmount { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 21)]
        public decimal? BooksAmount { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public DateTime? ExpenseChangeDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public YesNoType? IsUtilitiesIncludedShelterCost { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public decimal? TotalExpenseAmount { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public int? PaidToIndividualId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string PaidToNonMemberName { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public string IsPrimarySource { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ESICoverageDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int AddressId { get; set; }

        protected System.Nullable<System.DateTime> _ChangeEffectiveDate;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> ChangeEffectiveDate
        {
            get { return _ChangeEffectiveDate; }
            set
            {
                _ChangeEffectiveDate = value;
                ChangeEffectiveDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ChangeEffectiveDateSpecified { get; set; }

        protected System.Nullable<int> _IndividualId;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<int> IndividualId
        {
            get { return _IndividualId; }
            set
            {
                _IndividualId = value;
                IndividualIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IndividualIdSpecified { get; set; }

        protected System.Nullable<int> _PolicyHolderId;
        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<int> PolicyHolderId
        {
            get { return _PolicyHolderId; }
            set
            {
                _PolicyHolderId = value;
                PolicyHolderIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyHolderIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PolicyHolderFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string PolicyHolderLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string PolicyHolderMiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string PolicyHolderSuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string TypeOfCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string Ein { get; set; }

        [XmlElementAttribute(Order = 11)]
        public string AddressLine1 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string AddressLine2 { get; set; }

        [XmlElementAttribute(Order = 13)]
        public string City { get; set; }

        [XmlElementAttribute(Order = 14)]
        public string State { get; set; }

        [XmlElementAttribute(Order = 15)]
        public string ZipCode5 { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string PhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string PhoneExtension { get; set; }

        [XmlElementAttribute(Order = 18)]
        public YesNoType IsPotentialyCovered { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string EmployersContactFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string EmployersContactLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string EmployersContactMiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string EmployersContactEmail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string EmployersContactPhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string EmployersContactPhoneExtension { get; set; }

        protected System.Nullable<decimal> _PremiumAmount;

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public System.Nullable<decimal> PremiumAmount
        {
            get { return _PremiumAmount; }
            set
            {
                _PremiumAmount = value;
                PremiumAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PremiumAmountSpecified { get; set; }

        protected System.Nullable<decimal> _NewPremiumAmount;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<decimal> NewPremiumAmount
        {
            get { return _NewPremiumAmount; }
            set
            {
                _NewPremiumAmount = value;
                NewPremiumAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool NewPremiumAmountSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public string PayFrequencyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public string NewPayFrequencyCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string ExpectingChangeInCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public string IsEnrollingNextYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public string IsPlanningToEnrollInEmployerHealthPlanCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public string IsPolicyHolderMemberOfCase { get; set; }

        protected System.Nullable<System.DateTime> _CoverageStartDateNextYear;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<System.DateTime> CoverageStartDateNextYear
        {
            get { return _CoverageStartDateNextYear; }
            set
            {
                _CoverageStartDateNextYear = value;
                CoverageStartDateNextYearSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageStartDateNextYearSpecified { get; set; }

        protected System.Nullable<System.DateTime> _CoverageEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<System.DateTime> CoverageEndDate
        {
            get { return _CoverageEndDate; }
            set
            {
                _CoverageEndDate = value;
                CoverageEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 35)]
        public int ESICoverageDetailId { get; set; }

        [XmlElementAttribute(Order = 36)]
        public int EmployerId { get; set; }

        [XmlElementAttribute(Order = 37)]
        public int InsuranceEmployerHealthCoverageId { get; set; }

        [XmlElementAttribute(Order = 38)]
        public int InsuranceExternalPolicyHolderId { get; set; }

        [XmlElementAttribute(Order = 39)]
        public string RelationshipToPolicyHolder { get; set; }

        [XmlElementAttribute(Order = 40)]
        public string IsAnyoneUnableToEnroll { get; set; }
        [XmlElementAttribute(Order = 41)]
        public int? ResponsiblePartyIndividualId { get; set; }

        [XmlElementAttribute(Order = 42)]
        public string GoodCauseReason { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EmploymentDetail : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int EmploymentDetaild { get; set; }

        protected int _SSPEmploymentDetaild;
        [XmlElementAttribute(Order = 1)]
        public int SSPEmploymentDetaild
        {
            get { return _SSPEmploymentDetaild; }
            set
            {
                _SSPEmploymentDetaild = value;
                SSPEmploymentDetaildSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPEmploymentDetaildSpecified { get; set; }

        protected System.Nullable<System.DateTime> _BeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get { return _BeginDate; }
            set
            {
                _BeginDate = value;
                BeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EndDate;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return _EndDate; }
            set
            {
                _EndDate = value;
                EndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string EmployerName { get; set; }

        [XmlElementAttribute(Order = 5)]
        public YesNoType HasLostEmployment { get; set; }

        protected System.Nullable<System.DateTime> _EmploymentStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> EmploymentStartDate
        {
            get { return _EmploymentStartDate; }
            set
            {
                _EmploymentStartDate = value;
                EmploymentStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmploymentStartDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string LossOfEmploymentReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string LossOfEmploymentVerificationCode { get; set; }

        protected System.Nullable<int> _AddressId;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<int> AddressId
        {
            get { return _AddressId; }
            set
            {
                _AddressId = value;
                AddressIdSpecified = true;
            }
        }
        [XmlIgnoreAttribute]
        public bool AddressIdSpecified { get; set; }

        protected System.Nullable<int> _Ein;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<int> Ein
        {
            get { return _Ein; }
            set
            {
                _Ein = value;
                EinSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EinSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EmploymentEndDate;
        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> EmploymentEndDate
        {
            get { return _EmploymentEndDate; }
            set
            {
                _EmploymentEndDate = value;
                EmploymentEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmploymentEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public string PhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string PhoneExtension { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string EmploymentTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string Source { get; set; }

        [XmlElementAttribute(Order = 16)]
        public IncomePayDetail IncomePayDetail { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string JobTitle { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public DateTime? LastPayDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public DateTime? FirstPayDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public DateTime? DateOfChange { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public YesNoType? NeedChildCareHours { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string IncomeTypeCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string IncomeCategoryCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 24)]

        public string AttendingProgramCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string IsReceivingCashCheck { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string IsUsedToPayChildCare { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public string IsTemporarilyOnLeave { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public string LeaveReasonCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public DateTime? ExpectedDateOfReturn { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public DateTime? TemporaryLeaveDate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public string IsTemporarilyOnLeaveDueToSickChild { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public int? ChildIndividualId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ESICoveredIndividuals : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int CoveredIndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string RelationshipCode { get; set; }

        protected System.Nullable<YesNoType> _IsUpdate;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsUpdate
        {
            get { return _IsUpdate; }
            set
            {
                _IsUpdate = value;
                IsUpdateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUpdateSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public string[] SelectedReasonCodes { get; set; }

        [XmlElementAttribute(Order = 4)]
        public System.Nullable<System.DateTime> CoverageStartDate { get; set; }

        [XmlElementAttribute(Order = 5)]
        public System.Nullable<System.DateTime> CoverageEndDate { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EmploymentInfo : controlInfo
    {
        protected System.Nullable<int> _InsuranceInternalPolicyHolderId;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> InsuranceInternalPolicyHolderId
        {
            get { return _InsuranceInternalPolicyHolderId; }
            set
            {
                _InsuranceInternalPolicyHolderId = value;
                InsuranceInternalPolicyHolderIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceInternalPolicyHolderIdSpecified { get; set; }

        [XmlElementAttribute("ESICoveredIndividuals", Order = 1)]
        public ESICoveredIndividuals[] ESICoveredIndividuals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string InsuranceGroupNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string TypeOfFacility { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string PolicyVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string ReasonForLosingHealthCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string HasInsuranceCard { get; set; }

        [XmlElementAttribute(Order = 7)]
        public InsuranceCompany InsuranceCompany { get; set; }

        protected System.Nullable<int> _EIN;
        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<int> EIN
        {
            get { return _EIN; }
            set
            {
                _EIN = value;
                EINSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EINSpecified { get; set; }

        protected System.Nullable<byte> _HoursWorkedPerWeek;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<byte> HoursWorkedPerWeek
        {
            get { return _HoursWorkedPerWeek; }
            set
            {
                _HoursWorkedPerWeek = value;
                HoursWorkedPerWeekSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HoursWorkedPerWeekSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> IsHealthCoverage
        {
            get { return _IsHealthCoverage; }
            set
            {
                _IsHealthCoverage = value;
                IsHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrolled;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsEnrolled
        {
            get { return _IsEnrolled; }
            set
            {
                _IsEnrolled = value;
                IsEnrolledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrolledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _FutureEnrollmentDate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> FutureEnrollmentDate
        {
            get { return _FutureEnrollmentDate; }
            set
            {
                _FutureEnrollmentDate = value;
                FutureEnrollmentDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool FutureEnrollmentDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string LowestCostPlan { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string MecCd { get; set; }

        protected System.Nullable<decimal> _IndividualContribution;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<decimal> IndividualContribution
        {
            get { return _IndividualContribution; }
            set
            {
                _IndividualContribution = value;
                IndividualContributionSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IndividualContributionSpecified { get; set; }

        protected System.Nullable<decimal> _EmployeePremiumContribution;

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<decimal> EmployeePremiumContribution
        {
            get { return _EmployeePremiumContribution; }
            set
            {
                _EmployeePremiumContribution = value;
                EmployeePremiumContributionSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmployeePremiumContributionSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string FrequencyCode { get; set; }

        [XmlElementAttribute(Order = 18)]
        public int EmploymentDetaild { get; set; }

        protected int _SSPEmploymentDetaild;

        [XmlElementAttribute(Order = 19)]
        public int SSPEmploymentDetaild
        {
            get { return _SSPEmploymentDetaild; }
            set
            {
                _SSPEmploymentDetaild = value;
                SSPEmploymentDetaildSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SSPEmploymentDetaildSpecified { get; set; }

        [XmlElementAttribute(Order = 20)]
        public YesNoType IsCoveredNextYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string IsDependentCovered { get; set; }

        [XmlElementAttribute(Order = 22)]
        public YesNoType IsChangeExpectedInCoverageNextYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string CoverageChangeReasonNextYear { get; set; }

        protected System.Nullable<System.DateTime> _CoverageLastDate;

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public System.Nullable<System.DateTime> CoverageLastDate
        {
            get { return _CoverageLastDate; }
            set
            {
                _CoverageLastDate = value;
                CoverageLastDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageLastDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string NewPayFrequencyCode { get; set; }

        protected System.Nullable<System.DateTime> _ChangeEffectiveDate;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<System.DateTime> ChangeEffectiveDate
        {
            get { return _ChangeEffectiveDate; }
            set
            {
                _ChangeEffectiveDate = value;
                ChangeEffectiveDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ChangeEffectiveDateSpecified { get; set; }

        [XmlElementAttribute(Order = 27)]
        public YesNoType IsIndividualDroppingCoverageNextYear { get; set; }

        protected System.Nullable<System.DateTime> _CoverageStartDateNextYear;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<System.DateTime> CoverageStartDateNextYear
        {
            get { return _CoverageStartDateNextYear; }
            set
            {
                _CoverageStartDateNextYear = value;
                CoverageStartDateNextYearSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageStartDateNextYearSpecified { get; set; }

        protected System.Nullable<int> _InsurancePolicyDetailId;

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public System.Nullable<int> InsurancePolicyDetailId
        {
            get { return _InsurancePolicyDetailId; }
            set
            {
                _InsurancePolicyDetailId = value;
                InsurancePolicyDetailIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsurancePolicyDetailIdSpecified { get; set; }

        protected System.Nullable<int> _InsuranceEmployerHealthCoverageId;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<int> InsuranceEmployerHealthCoverageId
        {
            get { return _InsuranceEmployerHealthCoverageId; }
            set
            {
                _InsuranceEmployerHealthCoverageId = value;
                InsuranceEmployerHealthCoverageIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool InsuranceEmployerHealthCoverageIdSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public string EmployerContactEmail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public string EmployerContactPhoneNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public string EmployerContactPhoneExtension { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public string InsuranceCompanyName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public string InsurancePolicyNumber { get; set; }

        protected System.Nullable<System.DateTime> _PolicyBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<System.DateTime> PolicyBeginDate
        {
            get { return _PolicyBeginDate; }
            set
            {
                _PolicyBeginDate = value;
                PolicyBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _PolicyEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<System.DateTime> PolicyEndDate
        {
            get { return _PolicyEndDate; }
            set
            {
                _PolicyEndDate = value;
                PolicyEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool PolicyEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string TypeOfCoverageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PolicyHolderFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public string EmployerContactFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public string EmployerContactLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public string EmployerContactMiddleInitial { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 43)]
        public string IsAnyoneUnableToUseInsurance { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 44)]
        public string IsPolicyHolderMemberOfCase { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public int? InsuranceExternalPolicyHolderId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public string PolicyHolderLastName { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public string PolicyHolderMiddleInitial { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string PolicyHolderSuffixCode { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public DateTime? PolicyHolderDateOfBirthDate { get; set; }


    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Employer : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public Address Address { get; set; }

        [XmlElementAttribute(Order = 1)]
        public EmploymentInfo EmploymentInfo { get; set; }

        [XmlElementAttribute(Order = 2)]
        public EmploymentDetail EmploymentDetail { get; set; }
        [XmlElement(Order = 3)]
        public bool HasCoverageWithNoIncome { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public MedicalCoverage IndividualPolicyHolderDetails { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class PresumptiveEligibility : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public System.DateTime BenefitBeginDate { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string MaritalStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string PresumptiveRole { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IsIncarcerated { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int HouseHoldSize { get; set; }

        [XmlElementAttribute(Order = 5)]
        public decimal HouseHoldIncome { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string HasPreviouslyReceivedForSamePregnancy { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public string HasGotBenefitsThisCalendarYear { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string IsWicReferral { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string WasEverInFosterCare { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string FosterCareStateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string WasReceivingMedicaidInFosterCareState { get; set; }

        protected System.Nullable<int> _AgeWhenLeftFosterCare;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<int> AgeWhenLeftFosterCare
        {
            get { return _AgeWhenLeftFosterCare; }
            set
            {
                _AgeWhenLeftFosterCare = value;
                AgeWhenLeftFosterCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AgeWhenLeftFosterCareSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string IsParentCareTaker { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string IsPregnent { get; set; }

        [XmlElementAttribute("PresumptiveHealthInusrancePolicyDetails", IsNullable = true, Order = 15)]
        public PresumptiveHealthInusrancePolicyDetails[] PresumptiveHealthInusrancePolicyDetails { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string HasOtherInsurance { get; set; }

        [XmlElementAttribute(Order = 17)]
        public string CreateEntityCode { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualProfile : controlInfo
    {
        protected System.Nullable<YesNoType> _HasLegalImmigrationStatus;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<YesNoType> HasLegalImmigrationStatus
        {
            get { return _HasLegalImmigrationStatus; }
            set
            {
                _HasLegalImmigrationStatus = value;
                HasLegalImmigrationStatusSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasLegalImmigrationStatusSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsFullTimeStudent;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsFullTimeStudent
        {
            get { return _IsFullTimeStudent; }
            set
            {
                _IsFullTimeStudent = value;
                IsFullTimeStudentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsFullTimeStudentSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsReceivingMedicare;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsReceivingMedicare
        {
            get { return _IsReceivingMedicare; }
            set
            {
                _IsReceivingMedicare = value;
                IsReceivingMedicareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsReceivingMedicareSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsReceivingSsiBenefits;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsReceivingSsiBenefits
        {
            get { return _IsReceivingSsiBenefits; }
            set
            {
                _IsReceivingSsiBenefits = value;
                IsReceivingSsiBenefitsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsReceivingSsiBenefitsSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsDisabled;

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<YesNoType> IsDisabled
        {
            get { return _IsDisabled; }
            set
            {
                _IsDisabled = value;
                IsDisabledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDisabledSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsCommonWealth;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<YesNoType> IsCommonWealth
        {
            get { return _IsCommonWealth; }
            set
            {
                _IsCommonWealth = value;
                IsCommonWealthSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsCommonWealthSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsTobaccoUser;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<YesNoType> IsTobaccoUser
        {
            get { return _IsTobaccoUser; }
            set
            {
                _IsTobaccoUser = value;
                IsTobaccoUserSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsTobaccoUserSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsToBeReferredToWic;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<YesNoType> IsToBeReferredToWic
        {
            get { return _IsToBeReferredToWic; }
            set
            {
                _IsToBeReferredToWic = value;
                IsToBeReferredToWicSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsToBeReferredToWicSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsIncarceration;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<YesNoType> IsIncarceration
        {
            get { return _IsIncarceration; }
            set
            {
                _IsIncarceration = value;
                IsIncarcerationSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsIncarcerationSpecified { get; set; }


        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string IsIntendToReside { get; set; }


        protected System.Nullable<YesNoType> _IsJobSearch;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<YesNoType> IsJobSearch
        {
            get { return _IsJobSearch; }
            set
            {
                _IsJobSearch = value;
                IsJobSearchSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsJobSearchSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasDifferentMailingAddress;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> HasDifferentMailingAddress
        {
            get { return _HasDifferentMailingAddress; }
            set
            {
                _HasDifferentMailingAddress = value;
                HasDifferentMailingAddressSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasDifferentMailingAddressSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsStartSupplemented;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsStartSupplemented
        {
            get { return _IsStartSupplemented; }
            set
            {
                _IsStartSupplemented = value;
                IsStartSupplementedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsStartSupplementedSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<YesNoType> HasMedicalCoverage
        {
            get { return _HasMedicalCoverage; }
            set
            {
                _HasMedicalCoverage = value;
                HasMedicalCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalExpense;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<YesNoType> HasMedicalExpense
        {
            get { return _HasMedicalExpense; }
            set
            {
                _HasMedicalExpense = value;
                HasMedicalExpenseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalExpenseSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<YesNoType> HasHealthCoverage
        {
            get { return _HasHealthCoverage; }
            set
            {
                _HasHealthCoverage = value;
                HasHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsImmigrated;

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public System.Nullable<YesNoType> IsImmigrated
        {
            get { return _IsImmigrated; }
            set
            {
                _IsImmigrated = value;
                IsImmigratedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsImmigratedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEligibleForIndianHealthServices;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<YesNoType> IsEligibleForIndianHealthServices
        {
            get { return _IsEligibleForIndianHealthServices; }
            set
            {
                _IsEligibleForIndianHealthServices = value;
                IsEligibleForIndianHealthServicesSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEligibleForIndianHealthServicesSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<YesNoType> IsRepresentative
        {
            get { return _IsRepresentative; }
            set
            {
                _IsRepresentative = value;
                IsRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRepresentativeSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasCooperationMedicalSupport;

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<YesNoType> HasCooperationMedicalSupport
        {
            get { return _HasCooperationMedicalSupport; }
            set
            {
                _HasCooperationMedicalSupport = value;
                HasCooperationMedicalSupportSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasCooperationMedicalSupportSpecified { get; set; }

        protected System.Nullable<YesNoType> _HadPregnancyInLast3Months;

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public System.Nullable<YesNoType> HadPregnancyInLast3Months
        {
            get { return _HadPregnancyInLast3Months; }
            set
            {
                _HadPregnancyInLast3Months = value;
                HadPregnancyInLast3MonthsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HadPregnancyInLast3MonthsSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastPregnancyDate;

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public System.Nullable<System.DateTime> LastPregnancyDate
        {
            get { return _LastPregnancyDate; }
            set
            {
                _LastPregnancyDate = value;
                LastPregnancyDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastPregnancyDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string NonCooperationReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string NonCooperationComment { get; set; }

        protected System.Nullable<YesNoType> _IsStateSupplement;

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public System.Nullable<YesNoType> IsStateSupplement
        {
            get { return _IsStateSupplement; }
            set
            {
                _IsStateSupplement = value;
                IsStateSupplementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsStateSupplementSpecified { get; set; }

        protected System.Nullable<System.DateTime> _GraduationDate;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<System.DateTime> GraduationDate
        {
            get { return _GraduationDate; }
            set
            {
                _GraduationDate = value;
                GraduationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GraduationDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPregnant;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsPregnant
        {
            get { return _IsPregnant; }
            set
            {
                _IsPregnant = value;
                IsPregnantSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPregnantSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsDcbsEmployee;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsDcbsEmployee
        {
            get { return _IsDcbsEmployee; }
            set
            {
                _IsDcbsEmployee = value;
                IsDcbsEmployeeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDcbsEmployeeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string StudentVerificationCode { get; set; }

        [XmlElementAttribute(Order = 30)]
        public int IndividualId { get; set; }

        [XmlElementAttribute(Order = 31)]
        public int ApplicationNumber { get; set; }

        protected System.Nullable<System.DateTime> _SsiBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<System.DateTime> SsiBeginDate
        {
            get { return _SsiBeginDate; }
            set
            {
                _SsiBeginDate = value;
                SsiBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SsiBeginDateSpecified { get; set; }

        protected string _IsLongTermCareRequired;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public string IsLongTermCareRequired
        {
            get { return _IsLongTermCareRequired; }
            set
            {
                _IsLongTermCareRequired = value;
                IsLongTermCareRequiredSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLongTermCareRequiredSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsFosterCare;

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<YesNoType> IsFosterCare
        {
            get { return _IsFosterCare; }
            set
            {
                _IsFosterCare = value;
                IsFosterCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsFosterCareSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public string FosterCareStateCode { get; set; }

        protected System.Nullable<YesNoType> _IsStateMedicaidprogramCode;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsStateMedicaidprogramCode
        {
            get { return _IsStateMedicaidprogramCode; }
            set
            {
                _IsStateMedicaidprogramCode = value;
                IsStateMedicaidprogramCodeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsStateMedicaidprogramCodeSpecified { get; set; }

        protected System.Nullable<int> _AgeAtFosterCare;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<int> AgeAtFosterCare
        {
            get { return _AgeAtFosterCare; }
            set
            {
                _AgeAtFosterCare = value;
                AgeAtFosterCareSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AgeAtFosterCareSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public System.Nullable<YesNoType> HasPendingAccidentSettlement { get; set; }

        protected System.Nullable<YesNoType> _IsMigrantSeasonalFarmworker;

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public System.Nullable<YesNoType> IsMigrantSeasonalFarmworker
        {
            get { return _IsMigrantSeasonalFarmworker; }
            set
            {
                _IsMigrantSeasonalFarmworker = value;
                IsMigrantSeasonalFarmworkerSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsMigrantSeasonalFarmworkerSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsSingleParentAdoption { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsContactedforHomeCare { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 42)]
        public string PrimaryIdentityCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 43)]
        public YesNoType? HasFederallyRecognizedTribeEnrolledParent { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 44)]
        public YesNoType? HasIndianReservation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 45)]
        public YesNoType? HasIndianAllotment { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 46)]
        public YesNoType? IsIndianCommunityDependent { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 47)]
        public string IndianReservationCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 48)]
        public string IndianAllotmentNameCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 49)]
        public string DependentIndianCommunityNameCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 50)]
        public string IsUSVeteran { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 51)]
        public string IsActiveDutyInMilitary { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 52)]
        public string IsNationalGuardorMilitaryReserveUnit { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 53)]
        public string IsRequestingODVAContact { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 54)]
        public DateTime? CitizenshipClientReportedDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 55)]
        public DateTime? ImmigrationStatusReportedDate { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 56)]
        public string IsPlanningToStayInOregon { get; set; }
        [XmlElementAttribute(Order = 57)]
        public DateTime? ExpectedDateOfReturn { get; set; }
        [XmlElementAttribute(Order = 58)]
        public string IsLivingWithPrimaryApplicant { get; set; }
        [XmlElementAttribute(Order = 59)]
        public string IndividualInCaseReasonCode { get; set; }
        [XmlElementAttribute(Order = 60)]
        public string OtherTribeName { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 61)]
        public System.Nullable<YesNoType> IsMarried { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 62)]
        public System.Nullable<YesNoType> HasSpecialIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 63)]
        public System.Nullable<YesNoType> HasXfrAsset { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 64)]
        public System.Nullable<YesNoType> HasTrustAnnuity { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> HasAckLTCPreScreen { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 66)]
        public string WasFulltimeArmedForcesOrNationalGuard { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EmployerRosterDependent : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public int DependentIndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string MatchCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IsActive { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EmployerRoster : controlInfo
    {
        protected System.Nullable<int> _EmployerFEIN;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> EmployerFEIN
        {
            get { return _EmployerFEIN; }
            set
            {
                _EmployerFEIN = value;
                EmployerFEINSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmployerFEINSpecified { get; set; }

        [XmlElementAttribute(Order = 1)]
        public int RosterEmployerId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string RosterEmployerName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string OptOutStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string VerificationSourceCode { get; set; }

        protected System.Nullable<System.DateTime> _JoiningDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> JoiningDate
        {
            get { return _JoiningDate; }
            set
            {
                _JoiningDate = value;
                JoiningDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool JoiningDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EmploymentEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> EmploymentEndDate
        {
            get { return _EmploymentEndDate; }
            set
            {
                _EmploymentEndDate = value;
                EmploymentEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EmploymentEndDateSpecified { get; set; }

        [XmlElementAttribute(Order = 8)]
        public decimal LowestPlanPremium { get; set; }

        [XmlElementAttribute(Order = 9)]
        public decimal TotalGrossIncome { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string EmploymentStatus { get; set; }

        protected System.Nullable<System.DateTime> _EnrollmentStartDate;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> EnrollmentStartDate
        {
            get { return _EnrollmentStartDate; }
            set
            {
                _EnrollmentStartDate = value;
                EnrollmentStartDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EnrollmentStartDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _EnrollmentEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.DateTime> EnrollmentEndDate
        {
            get { return _EnrollmentEndDate; }
            set
            {
                _EnrollmentEndDate = value;
                EnrollmentEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool EnrollmentEndDateSpecified { get; set; }

        [XmlElementAttribute("EmployerRosterDependent", Order = 13)]
        public EmployerRosterDependent[] EmployerRosterDependent { get; set; }

        protected System.Nullable<System.DateTime> _CoverageBeginDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> CoverageBeginDate
        {
            get { return _CoverageBeginDate; }
            set
            {
                _CoverageBeginDate = value;
                CoverageBeginDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageBeginDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _CoverageEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> CoverageEndDate
        {
            get { return _CoverageEndDate; }
            set
            {
                _CoverageEndDate = value;
                CoverageEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageEndDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<YesNoType> IsRenewed { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Individual : controlInfo
    {
        protected string _IsHispanicLatinoSpanish;

        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public string IsHispanicLatinoSpanish
        {
            get { return _IsHispanicLatinoSpanish; }
            set
            {
                _IsHispanicLatinoSpanish = value;
                IsHispanicLatinoSpanishSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsHispanicLatinoSpanishSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsCoverageMonth1;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsCoverageMonth1
        {
            get { return _IsCoverageMonth1; }
            set
            {
                _IsCoverageMonth1 = value;
                IsCoverageMonth1Specified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsCoverageMonth1Specified { get; set; }

        protected System.Nullable<YesNoType> _IsCoverageMonth2;

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<YesNoType> IsCoverageMonth2
        {
            get { return _IsCoverageMonth2; }
            set
            {
                _IsCoverageMonth2 = value;
                IsCoverageMonth2Specified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsCoverageMonth2Specified { get; set; }

        protected System.Nullable<YesNoType> _IsCoverageMonth3;

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<YesNoType> IsCoverageMonth3
        {
            get { return _IsCoverageMonth3; }
            set
            {
                _IsCoverageMonth3 = value;
                IsCoverageMonth3Specified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsCoverageMonth3Specified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string HasLivedinUS { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public string TribeStateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public string EthnicityCode { get; set; }

        protected System.Nullable<System.DateTime> _BirthDate;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> BirthDate
        {
            get { return _BirthDate; }
            set
            {
                _BirthDate = value;
                BirthDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool BirthDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public string DateOfBirthVerifiedCode { get; set; }

        protected System.Nullable<System.DateTime> _DeathDate;

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public System.Nullable<System.DateTime> DeathDate
        {
            get { return _DeathDate; }
            set
            {
                _DeathDate = value;
                DeathDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DeathDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _DeathDateVerificationDate;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> DeathDateVerificationDate
        {
            get { return _DeathDateVerificationDate; }
            set
            {
                _DeathDateVerificationDate = value;
                DeathDateVerificationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DeathDateVerificationDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string IndianTribeCode { get; set; }

        protected System.Nullable<YesNoType> _IsFederalRecognizedIndianTribe;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsFederalRecognizedIndianTribe
        {
            get { return _IsFederalRecognizedIndianTribe; }
            set
            {
                _IsFederalRecognizedIndianTribe = value;
                IsFederalRecognizedIndianTribeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsFederalRecognizedIndianTribeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsFileCleared;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<YesNoType> IsFileCleared
        {
            get { return _IsFileCleared; }
            set
            {
                _IsFileCleared = value;
                IsFileClearedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsFileClearedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsSsaValidated;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<YesNoType> IsSsaValidated
        {
            get { return _IsSsaValidated; }
            set
            {
                _IsSsaValidated = value;
                IsSsaValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSsaValidatedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string SsaVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string MergeSeparateIndicator { get; set; }

        protected System.Nullable<YesNoType> _IsActive;

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public System.Nullable<YesNoType> IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;
                IsActiveSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsActiveSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsDelete;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<YesNoType> IsDelete
        {
            get { return _IsDelete; }
            set
            {
                _IsDelete = value;
                IsDeleteSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDeleteSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string DhsIdentification { get; set; }

        protected System.Nullable<YesNoType> _IsRequestForCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<YesNoType> IsRequestForCoverage
        {
            get { return _IsRequestForCoverage; }
            set
            {
                _IsRequestForCoverage = value;
                IsRequestForCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRequestForCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEmployerSponsorGroup;

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public System.Nullable<YesNoType> IsEmployerSponsorGroup
        {
            get { return _IsEmployerSponsorGroup; }
            set
            {
                _IsEmployerSponsorGroup = value;
                IsEmployerSponsorGroupSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEmployerSponsorGroupSpecified { get; set; }

        [XmlElementAttribute(Order = 22)]
        public string FirstName { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string LastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string MiddleInitial { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string SuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string NoReasonSsnCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public string RaceCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public string ReportedSsn { get; set; }

        [XmlElementAttribute(Order = 29)]
        public string GenderCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public string NativeVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public string StudentVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public string FederalHubVerificationCode { get; set; }

        protected System.Nullable<YesNoType> _IsFixedAddress;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsFixedAddress
        {
            get { return _IsFixedAddress; }
            set
            {
                _IsFixedAddress = value;
                IsFixedAddressSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsFixedAddressSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsHomeless;

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<YesNoType> IsHomeless
        {
            get { return _IsHomeless; }
            set
            {
                _IsHomeless = value;
                IsHomelessSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsHomelessSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public string TaxFileCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public string SevisId { get; set; }

        protected System.Nullable<System.DateTime> _SevisDate;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<System.DateTime> SevisDate
        {
            get { return _SevisDate; }
            set
            {
                _SevisDate = value;
                SevisDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool SevisDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string UserId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string OtherRaceCode { get; set; }

        [XmlElementAttribute(Order = 40)]
        public int IndividualId { get; set; }

        protected System.Nullable<bool> _addIndicator1;

        [XmlElementAttribute("addIndicator", IsNullable = true, Order = 41)]
        public System.Nullable<bool> addIndicator1
        {
            get { return _addIndicator1; }
            set
            {
                _addIndicator1 = value;
                addIndicator1Specified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool addIndicator1Specified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public string Ssn { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public string PseudoSsn { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public string TaxIdentificationNumber { get; set; }

        protected System.Nullable<YesNoType> _IsSsnValidated;

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public System.Nullable<YesNoType> IsSsnValidated
        {
            get { return _IsSsnValidated; }
            set
            {
                _IsSsnValidated = value;
                IsSsnValidatedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSsnValidatedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public string DeathDateVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public string MaidCardNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string MciId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string MciIdMatchLevel { get; set; }

        [XmlElementAttribute("EmployerRoster", Order = 50)]
        public EmployerRoster[] EmployerRoster { get; set; }

        protected System.Nullable<YesNoType> _USCitizenInd;

        [XmlElementAttribute(IsNullable = true, Order = 51)]
        public System.Nullable<YesNoType> USCitizenInd
        {
            get { return _USCitizenInd; }
            set
            {
                _USCitizenInd = value;
                USCitizenIndSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool USCitizenIndSpecified { get; set; }

        [XmlElementAttribute(Order = 52)]
        public IndividualProfile IndividualProfile { get; set; }

        [XmlElementAttribute(Order = 53)]
        public PresumptiveEligibility PresumptiveEligibility { get; set; }

        [XmlElementAttribute("Employer", Order = 54)]
        public Employer[] Employer { get; set; }

        [XmlElementAttribute(Order = 55)]
        public ESICoverageDetails ESICoverageDetails { get; set; }

        [XmlElementAttribute("Expense", Order = 56)]
        public Expense[] Expense { get; set; }

        [XmlElementAttribute("SelfEmploymentIncomeDetail", Order = 57)]
        public SelfEmploymentIncomeDetail[] SelfEmploymentIncomeDetail { get; set; }

        [XmlElementAttribute("UnearnedIncomeDetail", Order = 58)]
        public UnearnedIncomeDetail[] UnearnedIncomeDetail { get; set; }

        [XmlElementAttribute("OtherIncomeDetail", Order = 59)]
        public OtherIncomeDetail[] OtherIncomeDetail { get; set; }

        [XmlElementAttribute("ApplicationVerificationResult", Order = 60)]
        public ApplicationVerificationResult[] ApplicationVerificationResult { get; set; }

        [XmlElementAttribute(Order = 61)]
        public Incarceration Incarceration { get; set; }

        [XmlElementAttribute("MedicalCoverage", Order = 62)]
        public MedicalCoverage[] MedicalCoverage { get; set; }

        [XmlElementAttribute("Race", Order = 63)]
        public Race[] Race { get; set; }

        [XmlElementAttribute("VerifyCurrentIncome", Order = 64)]
        public VerifyCurrentIncome[] VerifyCurrentIncome { get; set; }

        [XmlElementAttribute("MedicalCoverageLoss", Order = 65)]
        public MedicalCoverageLoss[] MedicalCoverageLoss { get; set; }

        [XmlElementAttribute(Order = 66)]
        public Pregnancy[] Pregnancy { get; set; }

        [XmlElementAttribute("Relationship", Order = 67)]
        public Relationship[] Relationship { get; set; }

        [XmlElementAttribute("Contact", Order = 68)]
        public Contact[] Contact { get; set; }

        [XmlElementAttribute("Address", Order = 69)]
        public Address[] Address { get; set; }

        [XmlElementAttribute("MedicareDetails", Order = 70)]
        public MedicareDetails[] MedicareDetails { get; set; }

        [XmlElementAttribute(Order = 71)]
        public BCCTPEligibility BCCTPEligibility { get; set; }

        [XmlElementAttribute(Order = 72)]
        public WaiverAssociation WaiverAssociation { get; set; }

        protected System.Nullable<YesNoType> _HasSpecialNeed;

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public System.Nullable<YesNoType> HasSpecialNeed
        {
            get { return _HasSpecialNeed; }
            set
            {
                _HasSpecialNeed = value;
                HasSpecialNeedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSpecialNeedSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 74)]
        public string OtherSpokenLanguage { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 75)]
        public string OtherWrittenLanguageCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 76)]
        public string EnglishProficiencyCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 77)]
        public string IsInterpreterRequiredCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 78)]
        public string InterpretorComment { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 79)]
        public string SignLanguageInterpreterCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 80)]
        public string GenericIdentity { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 81)]
        public string DeclineToAnsForRaceEthnicity { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 82)]
        public string PrimeNumber { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 83)]
        public string IsCIFileCleared { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 84)]
        public YesNoType? IsActiveorHonorablyDischargedVeteran { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 85)]
        public YesNoType? IsSpouseorChildofActiveorHonorablyDischargedVeteran { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 86)]
        public YesNoType? IsWidowofHonorablyDischargedVeteran { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 87)]
        public string TypeofSignLanguageInterpretationCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 88)]
        public YesNoType? IsEmpMeetingIndNeeds { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 89)]
        public YesNoType? IsEmpMeetingIndNeedsUsingPreferredInterpretation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 90)]
        public string SignLanguageInterpretationComment { get; set; }

        [XmlElementAttribute("Nationality", Order = 91)]
        public Nationality[] Nationalities { get; set; }
        [XmlElementAttribute("Ethinicity", Order = 92)]
        public Ethinicity[] Ethinicities { get; set; }
        [XmlElementAttribute(Order = 93)]
        public string PrimaryIdentityCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 94)]
        public IndividualDisability IndividualDisability { get; set; }

        [XmlElement(IsNullable = true, Order = 95)]
        public YesNoType? IsSharedCustody { get; set; }
        [XmlElement(IsNullable = true, Order = 96)]
        public YesNoType? IsImmunizationCertificateCurrent { get; set; }
        [XmlElement(IsNullable = true, Order = 97)]
        public ESICoverageDetails[] EsiCoverageList { get; set; }
        [XmlElement(IsNullable = true, Order = 98)]
        public string ActiveDutyVeteranRelationship { get; set; }

        [XmlElement(IsNullable = true, Order = 99)]
        public string CountryOfOrigin { get; set; }
        [XmlElement(IsNullable = true, Order = 100)]
        public string IsPrevRefugeeStatus { get; set; }
        [XmlElement(IsNullable = true, Order = 101)]
        public string HasApprovedWithholdingRemovalDeport { get; set; }
        [XmlElement(IsNullable = true, Order = 102)]
        public DateTime? AlienTypeBeginDate { get; set; }
        [XmlElement(IsNullable = true, Order = 103)]
        public string HasAlienSponsor { get; set; }
        [XmlElement(IsNullable = true, Order = 104)]
        public string IsSponsoredByOrganization { get; set; }
        [XmlElement(IsNullable = true, Order = 105)]

        public SpecificIncomeDetails[] SpecificIncomes { get; set; }
        [XmlElement(IsNullable = true, Order = 106)]
        public string GenderIdentity { get; set; }
        [XmlElement(IsNullable = true, Order = 107)]
        public string GenderNotListed { get; set; }
        [XmlElementAttribute("AnnualIncome", Order = 108)]

        public AnnualIncomeDetails[] AnnualIncome { get; set; }
        [XmlElement(IsNullable = true, Order = 109)]
        public string HowIdentified { get; set; }
        [XmlElement(IsNullable = true, Order = 110)]
        public string IsProvidingSsn { get; set; }
        [XmlElement(IsNullable = true, Order = 111)]
        public string HasImmigrationStatus { get; set; }
        [XmlElement(Order = 112)]
        public bool IsRequestDateSameAsDOB { get; set; }
        [XmlElement(Order = 113)]
        public string PersonalNumber { get; set; }
        [XmlElement(IsNullable = true, Order = 114)]
        public string IsHispanicLatinaOrSpanish { get; set; }

        [XmlElementAttribute("IndividualLanguage", Order = 115)]
        public IndividualLanguage[] IndividualLanguages { get; set; }


        [XmlElement(IsNullable = true, Order = 116)]
        public string PreferredFirstName { get; set; }

        [XmlElement(IsNullable = true, Order = 117)]
        public string PreferredMiddleName { get; set; }

        [XmlElement(IsNullable = true, Order = 118)]
        public string PreferredLastName { get; set; }

        [XmlElement(IsNullable = true, Order = 119)]
        public string PreferredSuffix { get; set; }

        [XmlElement(IsNullable = true, Order = 120)]
        public string IsTransgender { get; set; }

        [XmlElementAttribute("IndividualGenderIdentity", Order = 121)]
        public IndividualGenderIdentity[] IndividualGenderIdentities { get; set; }

        [XmlElementAttribute("TribalLandDetail", Order = 122)]
        public TribalLandDetail[] TribalLandDetails { get; set; }

        [XmlElementAttribute("IsLegalNameToBeUsed", Order = 123)]
        public string IsLegalNameToBeUsed { get; set; }

        [XmlIgnoreAttribute]
        public bool SSNVerificationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _SSNVerificationDate;

        [XmlElementAttribute(IsNullable = true, Order = 124)]
        public System.Nullable<System.DateTime> SSNVerificationDate
        {
            get { return _SSNVerificationDate; }
            set
            {
                _SSNVerificationDate = value;
                SSNVerificationDateSpecified = true;
            }
        }
        [XmlElement(IsNullable = true, Order = 125)]
        public string WasLivingInAFGorUKR { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ApplicationIndividual : controlInfo
    {
        [XmlElementAttribute(Order = 0)]
        public YesNoType IsHeadOfHousehold { get; set; }

        protected System.Nullable<YesNoType> _IsEmployee;

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<YesNoType> IsEmployee
        {
            get { return _IsEmployee; }
            set
            {
                _IsEmployee = value;
                IsEmployeeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEmployeeSpecified { get; set; }

        [XmlElementAttribute(Order = 2)]
        public YesNoType IsMilitaryMember { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string TaxFileCurrent { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 4)]
        public string TaxFilePrevious { get; set; }

        protected System.Nullable<int> _TaxFilerIndividualIdPrevious;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> TaxFilerIndividualIdPrevious
        {
            get { return _TaxFilerIndividualIdPrevious; }
            set
            {
                _TaxFilerIndividualIdPrevious = value;
                TaxFilerIndividualIdPreviousSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxFilerIndividualIdPreviousSpecified { get; set; }

        protected System.Nullable<int> _TaxFilerIndividualIdCurrent;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<int> TaxFilerIndividualIdCurrent
        {
            get { return _TaxFilerIndividualIdCurrent; }
            set
            {
                _TaxFilerIndividualIdCurrent = value;
                TaxFilerIndividualIdCurrentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxFilerIndividualIdCurrentSpecified { get; set; }

        protected System.Nullable<int> _TaxFilerIndividualId;

        [XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> TaxFilerIndividualId
        {
            get { return _TaxFilerIndividualId; }
            set
            {
                _TaxFilerIndividualId = value;
                TaxFilerIndividualIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxFilerIndividualIdSpecified { get; set; }

        protected System.Nullable<System.DateTime> _CoverageLostDate;

        [XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> CoverageLostDate
        {
            get { return _CoverageLostDate; }
            set
            {
                _CoverageLostDate = value;
                CoverageLostDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CoverageLostDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 9)]
        public string CoverageLostTypeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public string CoverageLostReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public string IsApplicantRegisteredToVote { get; set; }

        protected System.Nullable<YesNoType> _IsSsnNameDifferent;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsSsnNameDifferent
        {
            get { return _IsSsnNameDifferent; }
            set
            {
                _IsSsnNameDifferent = value;
                IsSsnNameDifferentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSsnNameDifferentSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public string SsnFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public string SsnLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public string SsnMiddleName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 16)]
        public string SsnSuffixCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string AlienNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public string CitizenshipNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string CountryOfIssuanceCode { get; set; }

        protected System.Nullable<System.DateTime> _DocumentExpiryDate;

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<System.DateTime> DocumentExpiryDate
        {
            get { return _DocumentExpiryDate; }
            set
            {
                _DocumentExpiryDate = value;
                DocumentExpiryDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DocumentExpiryDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string DocumentOtherDescription { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string I94Number { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 23)]
        public string NaturalizationNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 24)]
        public string PassportNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 25)]
        public string ReceiptNumber { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public string VisaNumber { get; set; }

        protected System.Nullable<YesNoType> _IsImmigrationName;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsImmigrationName
        {
            get { return _IsImmigrationName; }
            set
            {
                _IsImmigrationName = value;
                IsImmigrationNameSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsImmigrationNameSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public string ImmigrationFirstName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string ImmigrationLastName { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public string ImmigrationMiddleName { get; set; }

        protected System.Nullable<System.DateTime> _ImmigrationDateOfBirth;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<System.DateTime> ImmigrationDateOfBirth
        {
            get { return _ImmigrationDateOfBirth; }
            set
            {
                _ImmigrationDateOfBirth = value;
                ImmigrationDateOfBirthSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ImmigrationDateOfBirthSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public string ImmigrationSuffix { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public string ImmigrationDocumentTypeCode { get; set; }

        protected System.Nullable<YesNoType> _IsDcbsLivingAtHome;

        [XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<YesNoType> IsDcbsLivingAtHome
        {
            get { return _IsDcbsLivingAtHome; }
            set
            {
                _IsDcbsLivingAtHome = value;
                IsDcbsLivingAtHomeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsDcbsLivingAtHomeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public string SpokenLanguageCode { get; set; }

        [XmlElementAttribute(Order = 36)]
        public Individual Individual { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public string NationalityCode { get; set; }

        protected System.Nullable<YesNoType> _IsActiveInCase;

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public System.Nullable<YesNoType> IsActiveInCase
        {
            get { return _IsActiveInCase; }
            set
            {
                _IsActiveInCase = value;
                IsActiveInCaseSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsActiveInCaseSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string CitizenshipVerificationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public string ResidencyStateCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public string ResidencyVerificationCode { get; set; }

        protected System.Nullable<YesNoType> _IsIntentionToResideInKentucky;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsIntentionToResideInKentucky
        {
            get { return _IsIntentionToResideInKentucky; }
            set
            {
                _IsIntentionToResideInKentucky = value;
                IsIntentionToResideInKentuckySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsIntentionToResideInKentuckySpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public string MaritalStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public string HouseHoldStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string NameofCarrier { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public string OtherHealthCoverageCode { get; set; }

        [XmlElementAttribute("ApplicationProgramIndividual", Order = 47)]
        public ApplicationProgramIndividual[] ApplicationProgramIndividual { get; set; }

        [XmlElementAttribute(Order = 48)]
        public SSA SSA { get; set; }

        [XmlElementAttribute(Order = 49)]
        public VLP[] VLP { get; set; }

        [XmlElementAttribute(Order = 50)]
        public S5B S5B { get; set; }

        [XmlElementAttribute(Order = 51)]
        public ESIMec ESIMec { get; set; }

        [XmlElementAttribute("NonESIMec", Order = 52)]
        public NonESIMec[] NonESIMec { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 53)]
        public System.Nullable<YesNoType> IsMCIUpdateRequired { get; set; }

        [XmlElementAttribute("StatusOfTaxFiling", Order = 54)]
        public StatusOfTaxFiling[] StatusOfTaxFiling { get; set; }

        [XmlElementAttribute(Order = 55)]
        public Resource Resource { get; set; }

        [XmlElementAttribute(Order = 56)]
        public LivingArrangement LivingArrangement { get; set; }

        [XmlElementAttribute("OutOfStateBenefits", Order = 57)]
        public OutOfStateBenefits[] OutOfStateBenefits { get; set; }

        [XmlElementAttribute(Order = 58)]
        public DisabilityInformation DisabilityInformation { get; set; }

        [XmlElementAttribute(Order = 59)]
        public IndividualEducation IndividualEducation { get; set; }

        [XmlElementAttribute("EntitledBenefits", Order = 60)]
        public EntitledBenefits[] EntitledBenefits { get; set; }

        protected System.Nullable<int> _ResidencyId;

        [XmlElementAttribute(IsNullable = true, Order = 61)]
        public System.Nullable<int> ResidencyId
        {
            get { return _ResidencyId; }
            set
            {
                _ResidencyId = value;
                ResidencyIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ResidencyIdSpecified { get; set; }

        [XmlElementAttribute(Order = 62)]
        public SSIBenefit SSIBenefit { get; set; }

        [XmlElementAttribute(Order = 63)]
        public EmergencyMedicalCondition EmergencyMedicalCondition { get; set; }

        [XmlElementAttribute(Order = 64)]
        public CISInformation CISInformation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public CareTakerService CareTakerService { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public DSNAPEmployerAddressInformation DSNAPEmployerAddressInformation { get; set; }

        [XmlElementAttribute("DSNAPIncomeDetails", Order = 67)]
        public DSNAPIncomeDetails[] DSNAPIncomeDetails { get; set; }

        [XmlElementAttribute("EducationExpense", IsNullable = true, Order = 68)]
        public EducationExpense[] EducationExpense { get; set; }

        [XmlElementAttribute("UnpaidEmploymentDetails", Order = 69)]
        public UnpaidEmploymentDetails[] UnpaidEmploymentDetails { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public WorkRequirementExemption WorkRequirementExemption { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public string AlienTypeCode { get; set; }
        [XmlElementAttribute("AccidentInjuryDetails", Order = 72)]
        public AccidentInjuryDetails[] AccidentInjuryDetails { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string EadCardNumber { get; set; }
        [XmlElementAttribute(Order = 74)]
        public Incarceration[] Incarcerations { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string IsPrevRefugeeStatus { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string HasApprovedWithholdingremovalDeport { get; set; }


        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public string ImmigrationStatusCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public int? IndividualContactInformationId { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public string IsLanguageInfoSameAsHoh { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public string HasAppropriateCareTakerInformation { get; set; }


    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class Application : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 84)]
        public Address[] CaseAddress { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 85)]
        public SafetyQuestion SafetyQuestions { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 86)]
        public string SignedUserFirstName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 87)]
        public string SignedUserLastName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 88)]
        public string SignedUserRole { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 89)]
        public CareTakerSchedule CareTakerEnrollmentSchedule { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 90)]
        public InterimConversionDetails[] InterimConversionDetails { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 91)]
        public CcoSelection[] CcoSelections { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 92)]
        public string IsToBeReferredToWic { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 93)]
        public string PersonMakingApplicationCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 94)]
        public CommunityPartner CommunityParnterDetails { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 96)]
        public string HasPartialAlienSponsorInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 97)]
        public int ApplicationSummaryRequestTriggerId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 98)]
        public bool IsMidRecertificationFlow { get; set; }
        [XmlElement(Order = 99)]
        public bool IsMidRecertificationAndRenewal { get; set; }
        [XmlElement(Order = 100)]
        public int[] CaseMergeExcludedIndividuals { get; set; }
        [XmlElement(Order = 101)]
        public string SnapSrsComments { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 102)]
        public TaskTypeComments[] TaskTypeComments { get; set; }


        [XmlElementAttribute(IsNullable = true, Order = 103)]
        public HouseholdQuestions HouseholdQuestions { get; set; }
        [XmlElement(Order = 104)]
        public string IsSameContactInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 105)]
        public AdditionalInformation[] AdditionalInformation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 106)]
        public string IsUSVeteran { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 107)]
        public ScreenCategoryMapping ScreenCategoryMapping { get; set; }
        [XmlElement(IsNullable = true, Order = 108)]

        public HouseholdQuestions CorrespondenceHouseholdQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 109)]

        public ResourceQuestions CorrespondenceResourceQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 110)]

        public IncomeQuestions CorrespondenceIncomeQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 111)]

        public ExpenseQuestions CorrespondenceExpenseQuestions { get; set; }

        [XmlElement(IsNullable = true, Order = 112)]

        public int? DisasterPeriodId { get; set; }

        [XmlElement(IsNullable = true, Order = 113)]
        public string CovidEmergencyExist { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 114)]
        public int ApplicationSummaryProcessingId { get; set; }

        [XmlElement(Order = 115)]
        public int[] ChildWithCustodialParents { get; set; }
        [XmlElement(Order = 116)]
        public int[] PrepopulatedIndividuals { get; set; }

        [XmlElement(IsNullable = true, Order = 117)]
        public System.Nullable<System.DateTime> DisabilityDemographicsDate { get; set; }
        [XmlElement(IsNullable = true, Order = 118)]
        public System.Nullable<System.DateTime> RaceEthnicityDate { get; set; }
        [XmlElement(IsNullable = true, Order = 119)]
        public System.Nullable<System.DateTime> LanguageCommunicationDate { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitApplicationResponseSubmitApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitApplicationForPrepopulatedDataResponseSubmitApplicationForPrepopulatedDataResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }


    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitSNAPShortApplicationApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitSNAPShortApplicationResponseSubmitSNAPShortApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitDisasterSNAPApplicationApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitDisasterSNAPApplicationResponseSubmitDisasterSNAPApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ReRunApplicationResponseReRunApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "ReRunApplication", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class ReRunApplicationRequest
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        [XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> applicationNumber { get; set; }

        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 1)]
        [XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> caseNumber { get; set; }

        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 2)]
        [XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> processingID { get; set; }

        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 3)]
        public bool isFileClearanceRerun { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "ReRunApplicationResponse", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class ReRunApplicationResponse
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponseReRunApplicationResult ReRunApplicationResult { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitPEApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitPEResponseSubmitPEResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitAdditionalApplicationDetailsResponseSubmitAdditionalApplicationDetailsResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ChangeApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 84)]
        public Address[] CaseAddress { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 85)]
        public SafetyQuestion SafetyQuestions { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 86)]
        public string SignedUserFirstName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 87)]
        public string SignedUserLastName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 88)]
        public string SignedUserRole { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 89)]
        public CareTakerSchedule CareTakerEnrollmentSchedule { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 90)]
        public InterimConversionDetails[] InterimConversionDetails { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 91)]
        public CcoSelection[] CcoSelections { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 92)]
        public string IsToBeReferredToWic { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 93)]
        public string PersonMakingApplicationCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 94)]
        public CommunityPartner CommunityParnterDetails { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 95)]
        public bool IsEstablishSnapFilingDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 96)]
        public string HasPartialAlienSponsorInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 97)]
        public int ApplicationSummaryRequestTriggerId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 98)]
        public bool IsMidRecertificationFlow { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 99)]
        public bool IsMidRecertificationAndRenewal { get; set; }
        [XmlElement(Order = 100)]
        public int[] CaseMergeExcludedIndividuals { get; set; }
        [XmlElement(Order = 101)]
        public string SnapSrsComments { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 102)]
        public TaskTypeComments[] TaskTypeComments { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 103)]
        public HouseholdQuestions HouseholdQuestions { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 104)]
        public string IsSameContactInformation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 105)]
        public AdditionalInformation[] AdditionalInformation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 106)]
        public string IsUSVeteran { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 107)]
        public ScreenCategoryMapping ScreenCategoryMapping { get; set; }
        [XmlElement(IsNullable = true, Order = 108)]

        public HouseholdQuestions CorrespondenceHouseholdQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 109)]

        public ResourceQuestions CorrespondenceResourceQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 110)]

        public IncomeQuestions CorrespondenceIncomeQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 111)]

        public ExpenseQuestions CorrespondenceExpenseQuestions { get; set; }
        [XmlElement(IsNullable = true, Order = 112)]

        public int? DisasterPeriodId { get; set; }

        [XmlElement(IsNullable = true, Order = 113)]
        public string CovidEmergencyExist { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 114)]
        public int ApplicationSummaryProcessingId { get; set; }

        [XmlElement(Order = 115)]
        public int[] ChildWithCustodialParents { get; set; }
        [XmlElement(IsNullable = true, Order = 116)]
        public System.Nullable<System.DateTime> DisabilityDemographicsDate { get; set; }
        [XmlElement(IsNullable = true, Order = 117)]
        public System.Nullable<System.DateTime> RaceEthnicityDate { get; set; }
        [XmlElement(IsNullable = true, Order = 118)]
        public System.Nullable<System.DateTime> LanguageCommunicationDate { get; set; }
        [XmlElement(IsNullable = true, Order = 119)]
        public string AreAdditionalCCHoursRequired { get; set; }
        private string[] needForAdditionalCCHoursField;
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 120)]
        public string[] NeedForAdditionalCCHoursRequired
        {
            get
            {
                return this.needForAdditionalCCHoursField;
            }
            set
            {
                this.needForAdditionalCCHoursField = value;
                this.RaisePropertyChanged("NeedForAdditionalCCHoursRequired");
            }
        }
        [XmlElement(IsNullable = true, Order = 121)]
        public string OtherReason { get; set; }
        [XmlElement(IsNullable = true, Order = 122)]
        public string IsRequestingFullTimeHours { get; set; }
        [XmlElement(IsNullable = true, Order = 123)]
        public string IsRequestingMoreThanFullTimeHours { get; set; }
        [XmlElement(IsNullable = true, Order = 124)]
        public string CurrentlyReceiving { get; set; }
        [XmlElement(IsNullable = true, Order = 125)]
        public string IsSourceMobile { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public int ApplicantUpdateDetailId { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class submitApplicationChangeResponseSubmitApplicationChangeResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class submitApplicationChangeAddressApplication : controlInfo
    {

        private PreviousCaseDetails previousCaseDetailField;

        private Renewals renewalsField;

        private string taskErrorCodeField;

        private int applicationNumberField;

        private int sSPApplicationNumberField;

        private System.Nullable<int> caseNumberField;

        private bool caseNumberFieldSpecified;

        private System.Nullable<System.DateTime> applicationReceivedDateField;

        private bool applicationReceivedDateFieldSpecified;

        private string applicationStatusCodeField;

        private string applicationSourceField;

        private string sourceField;

        private System.Nullable<bool> isEDBCAlreadyExecutedField;

        private bool isEDBCAlreadyExecutedFieldSpecified;

        private System.Nullable<YesNoType> isExpeditedField;

        private bool isExpeditedFieldSpecified;

        private System.Nullable<YesNoType> isScheduledField;

        private bool isScheduledFieldSpecified;

        private System.Nullable<System.DateTime> expeditedDeterminedDateField;

        private bool expeditedDeterminedDateFieldSpecified;

        private System.Nullable<System.DateTime> statusUpdatedDateField;

        private bool statusUpdatedDateFieldSpecified;

        private System.Nullable<System.DateTime> applicationStatusDateField;

        private bool applicationStatusDateFieldSpecified;

        private string applicationModeCodeField;

        private string programAddIndicatorField;

        private System.Nullable<int> officeNumberField;

        private bool officeNumberFieldSpecified;

        private string applicationWrittenLanguageCodeField;

        private string applicationSpokenLanguageCodeField;

        private string applicationSpecialAccomodationCodeField;

        private string applicationSourceCodeField;

        private string programCodeField;

        private YesNoType isFinancialAssistanceNeededField;

        private YesNoType isApplicantAuthorizedRepresentativeField;

        private System.Nullable<YesNoType> isEsignPenaltyOfPurgeryField;

        private bool isEsignPenaltyOfPurgeryFieldSpecified;

        private System.Nullable<YesNoType> isEsignChangeField;

        private bool isEsignChangeFieldSpecified;

        private System.Nullable<YesNoType> isEsignSettlementField;

        private bool isEsignSettlementFieldSpecified;

        private string federalRenewalCodeField;

        private System.Nullable<System.DateTime> authorizedAccessEndDateField;

        private bool authorizedAccessEndDateFieldSpecified;

        private System.Nullable<int> applicationRegistrationApplicationNumberField;

        private bool applicationRegistrationApplicationNumberFieldSpecified;

        private System.Nullable<YesNoType> isEsignField;

        private bool isEsignFieldSpecified;

        private System.Nullable<YesNoType> isPhoneConsentField;

        private bool isPhoneConsentFieldSpecified;

        private string[] applyingForProgramCodeField;

        private System.Nullable<System.DateTime> desiredCoverageDateField;

        private bool desiredCoverageDateFieldSpecified;

        private System.Nullable<YesNoType> isLossOfHealthCoverageField;

        private bool isLossOfHealthCoverageFieldSpecified;

        private System.Nullable<YesNoType> hasMedicalBillsField;

        private bool hasMedicalBillsFieldSpecified;

        private string optOutReasonCodeField;

        private string preferredEmailForSurveyField;

        private System.Nullable<YesNoType> isUsingEmployerCoverageField;

        private bool isUsingEmployerCoverageFieldSpecified;

        private System.Nullable<YesNoType> isEnrollmentESignField;

        private bool isEnrollmentESignFieldSpecified;

        private System.Nullable<YesNoType> isEnrollmentPhoneConsentField;

        private bool isEnrollmentPhoneConsentFieldSpecified;

        private System.Nullable<System.DateTime> applicationDateField;

        private bool applicationDateFieldSpecified;

        private System.Nullable<System.DateTime> applicationTimeField;

        private bool applicationTimeFieldSpecified;

        private string grossHeadofHouseholdIncomeFrequencyCodeField;

        private System.Nullable<decimal> grossHeadOfHouseholdIncomeAmountField;

        private bool grossHeadOfHouseholdIncomeAmountFieldSpecified;

        private System.Nullable<System.DateTime> lastCaseActionDateField;

        private bool lastCaseActionDateFieldSpecified;

        private string lastCaseActionCodeField;

        private string actionByUserField;

        private ApplicationIndividual[] applicationIndividualField;

        private NCPChildModel[] nCPChildModelField;

        private APTCAnnualIncome[] aPTCAnnualIncomeDetailsField;

        private Representative[] representativeField;

        private string taskCommentsField;

        private System.Nullable<YesNoType> voterRegistrationVisitedField;

        private bool voterRegistrationVisitedFieldSpecified;

        private System.Nullable<YesNoType> deactivateNCPField;

        private Program[] programField;

        private NonCustodialParent[] nonCustodialParentField;

        private Conviction convictionField;

        private ExpeditedSNAP expeditedSNAPField;

        private AlienSponsor[] alienSponsorField;

        private DSNAPExpenseDetails dSNAPExpenseDetailsField;

        private DSNAPDisasterQuestionDetails dSNAPDisasterQuestionDetailsField;

        private DSNAPResourceDetails[] dSNAPResourceDetailsField;

        private System.Nullable<YesNoType> isNonMagiField;

        private bool isNonMagiFieldSpecified;

        private System.Nullable<YesNoType> isRACAddIndividualsField;

        private bool isRACAddIndividualsFieldSpecified;

        private UserCaseAssociation userCaseAssociationField;

        private string portalCodeField;

        private ResourceQuestions resourceQuestionsField;

        private ExpenseQuestions expenseQuestionsField;

        private HouseHoldSituation houseHoldSituationField;

        private string userAttestationField;

        private string caseOwnershipCodeField;

        private string isEDBCToBeRunField;

        private string saveSubmitEarlyField;

        private string isUpdateIndividualRequiredField;

        private System.Nullable<int> taxReconcileIDField;

        private bool taxReconcileIDFieldSpecified;

        private System.Nullable<YesNoType> hasBenefitsFromOtherStateField;

        private bool hasBenefitsFromOtherStateFieldSpecified;

        private System.Nullable<YesNoType> hasSSIBenefitField;

        private bool hasSSIBenefitFieldSpecified;

        private IncomeQuestions incomeQuestionsField;

        private System.Nullable<YesNoType> isSignedbyAuthorizedRepresentativeField;

        private bool isSignedbyAuthorizedRepresentativeFieldSpecified;

        private System.Nullable<int> externalAuthorizedRepresentativeIdField;

        private bool externalAuthorizedRepresentativeIdFieldSpecified;

        //private AccountTransferInfo accountTransferInformationField;

        private Address[] caseAddressField;

        private SafetyQuestion safetyQuestionsField;

        private string signedUserFirstNameField;

        private string signedUserLastNameField;

        private string signedUserRoleField;

        private CareTakerSchedule careTakerEnrollmentScheduleField;

        private InterimConversionDetails[] interimConversionDetailsField;

        private CcoSelection[] ccoSelectionsField;

        private string isToBeReferredToWicField;

        private string personMakingApplicationCodeField;

        private CommunityPartner communityParnterDetailsField;

        private bool isEstablishSnapFilingDateField;

        private string hasPartialAlienSponsorInformationField;

        private int applicationSummaryRequestTriggerIdField;

        private bool isMidRecertificationFlowField;

        private bool isMidRecertificationAndRenewalField;

        private int[] caseMergeExcludedIndividualsField;

        private string snapSrsCommentsField;

        private TaskTypeComments[] taskTypeCommentsField;

        private HouseholdQuestions householdQuestionsField;

        private string isSameContactInformationField;

        private AdditionalInformation[] additionalInformationField;

        private string isUSVeteranField;

        private ScreenCategoryMapping screenCategoryMappingField;

        private HouseholdQuestions correspondenceHouseholdQuestionsField;

        private ResourceQuestions correspondenceResourceQuestionsField;

        private IncomeQuestions correspondenceIncomeQuestionsField;

        private ExpenseQuestions correspondenceExpenseQuestionsField;

        private System.Nullable<int> disasterPeriodIdField;

        private string covidEmergencyExistField;

        private int applicationSummaryProcessingIdField;

        private int[] childWithCustodialParentsField;

        private int[] prepopulatedIndividualsField;

        private System.Nullable<System.DateTime> disabilityDemographicsDateField;

        private System.Nullable<System.DateTime> raceEthnicityDateField;

        private System.Nullable<System.DateTime> languageCommunicationDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail
        {
            get
            {
                return this.previousCaseDetailField;
            }
            set
            {
                this.previousCaseDetailField = value;
                this.RaisePropertyChanged("PreviousCaseDetail");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals
        {
            get
            {
                return this.renewalsField;
            }
            set
            {
                this.renewalsField = value;
                this.RaisePropertyChanged("Renewals");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode
        {
            get
            {
                return this.taskErrorCodeField;
            }
            set
            {
                this.taskErrorCodeField = value;
                this.RaisePropertyChanged("TaskErrorCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int ApplicationNumber
        {
            get
            {
                return this.applicationNumberField;
            }
            set
            {
                this.applicationNumberField = value;
                this.RaisePropertyChanged("ApplicationNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber
        {
            get
            {
                return this.sSPApplicationNumberField;
            }
            set
            {
                this.sSPApplicationNumberField = value;
                this.RaisePropertyChanged("SSPApplicationNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get
            {
                return this.caseNumberField;
            }
            set
            {
                this.caseNumberField = value;
                this.RaisePropertyChanged("CaseNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseNumberSpecified
        {
            get
            {
                return this.caseNumberFieldSpecified;
            }
            set
            {
                this.caseNumberFieldSpecified = value;
                this.RaisePropertyChanged("CaseNumberSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get
            {
                return this.applicationReceivedDateField;
            }
            set
            {
                this.applicationReceivedDateField = value;
                this.RaisePropertyChanged("ApplicationReceivedDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationReceivedDateSpecified
        {
            get
            {
                return this.applicationReceivedDateFieldSpecified;
            }
            set
            {
                this.applicationReceivedDateFieldSpecified = value;
                this.RaisePropertyChanged("ApplicationReceivedDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode
        {
            get
            {
                return this.applicationStatusCodeField;
            }
            set
            {
                this.applicationStatusCodeField = value;
                this.RaisePropertyChanged("ApplicationStatusCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string ApplicationSource
        {
            get
            {
                return this.applicationSourceField;
            }
            set
            {
                this.applicationSourceField = value;
                this.RaisePropertyChanged("ApplicationSource");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                this.RaisePropertyChanged("Source");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get
            {
                return this.isEDBCAlreadyExecutedField;
            }
            set
            {
                this.isEDBCAlreadyExecutedField = value;
                this.RaisePropertyChanged("IsEDBCAlreadyExecuted");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEDBCAlreadyExecutedSpecified
        {
            get
            {
                return this.isEDBCAlreadyExecutedFieldSpecified;
            }
            set
            {
                this.isEDBCAlreadyExecutedFieldSpecified = value;
                this.RaisePropertyChanged("IsEDBCAlreadyExecutedSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get
            {
                return this.isExpeditedField;
            }
            set
            {
                this.isExpeditedField = value;
                this.RaisePropertyChanged("IsExpedited");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsExpeditedSpecified
        {
            get
            {
                return this.isExpeditedFieldSpecified;
            }
            set
            {
                this.isExpeditedFieldSpecified = value;
                this.RaisePropertyChanged("IsExpeditedSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get
            {
                return this.isScheduledField;
            }
            set
            {
                this.isScheduledField = value;
                this.RaisePropertyChanged("IsScheduled");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsScheduledSpecified
        {
            get
            {
                return this.isScheduledFieldSpecified;
            }
            set
            {
                this.isScheduledFieldSpecified = value;
                this.RaisePropertyChanged("IsScheduledSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get
            {
                return this.expeditedDeterminedDateField;
            }
            set
            {
                this.expeditedDeterminedDateField = value;
                this.RaisePropertyChanged("ExpeditedDeterminedDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpeditedDeterminedDateSpecified
        {
            get
            {
                return this.expeditedDeterminedDateFieldSpecified;
            }
            set
            {
                this.expeditedDeterminedDateFieldSpecified = value;
                this.RaisePropertyChanged("ExpeditedDeterminedDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get
            {
                return this.statusUpdatedDateField;
            }
            set
            {
                this.statusUpdatedDateField = value;
                this.RaisePropertyChanged("StatusUpdatedDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusUpdatedDateSpecified
        {
            get
            {
                return this.statusUpdatedDateFieldSpecified;
            }
            set
            {
                this.statusUpdatedDateFieldSpecified = value;
                this.RaisePropertyChanged("StatusUpdatedDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get
            {
                return this.applicationStatusDateField;
            }
            set
            {
                this.applicationStatusDateField = value;
                this.RaisePropertyChanged("ApplicationStatusDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationStatusDateSpecified
        {
            get
            {
                return this.applicationStatusDateFieldSpecified;
            }
            set
            {
                this.applicationStatusDateFieldSpecified = value;
                this.RaisePropertyChanged("ApplicationStatusDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode
        {
            get
            {
                return this.applicationModeCodeField;
            }
            set
            {
                this.applicationModeCodeField = value;
                this.RaisePropertyChanged("ApplicationModeCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator
        {
            get
            {
                return this.programAddIndicatorField;
            }
            set
            {
                this.programAddIndicatorField = value;
                this.RaisePropertyChanged("ProgramAddIndicator");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get
            {
                return this.officeNumberField;
            }
            set
            {
                this.officeNumberField = value;
                this.RaisePropertyChanged("OfficeNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfficeNumberSpecified
        {
            get
            {
                return this.officeNumberFieldSpecified;
            }
            set
            {
                this.officeNumberFieldSpecified = value;
                this.RaisePropertyChanged("OfficeNumberSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode
        {
            get
            {
                return this.applicationWrittenLanguageCodeField;
            }
            set
            {
                this.applicationWrittenLanguageCodeField = value;
                this.RaisePropertyChanged("ApplicationWrittenLanguageCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode
        {
            get
            {
                return this.applicationSpokenLanguageCodeField;
            }
            set
            {
                this.applicationSpokenLanguageCodeField = value;
                this.RaisePropertyChanged("ApplicationSpokenLanguageCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode
        {
            get
            {
                return this.applicationSpecialAccomodationCodeField;
            }
            set
            {
                this.applicationSpecialAccomodationCodeField = value;
                this.RaisePropertyChanged("ApplicationSpecialAccomodationCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode
        {
            get
            {
                return this.applicationSourceCodeField;
            }
            set
            {
                this.applicationSourceCodeField = value;
                this.RaisePropertyChanged("ApplicationSourceCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string ProgramCode
        {
            get
            {
                return this.programCodeField;
            }
            set
            {
                this.programCodeField = value;
                this.RaisePropertyChanged("ProgramCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded
        {
            get
            {
                return this.isFinancialAssistanceNeededField;
            }
            set
            {
                this.isFinancialAssistanceNeededField = value;
                this.RaisePropertyChanged("IsFinancialAssistanceNeeded");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative
        {
            get
            {
                return this.isApplicantAuthorizedRepresentativeField;
            }
            set
            {
                this.isApplicantAuthorizedRepresentativeField = value;
                this.RaisePropertyChanged("IsApplicantAuthorizedRepresentative");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get
            {
                return this.isEsignPenaltyOfPurgeryField;
            }
            set
            {
                this.isEsignPenaltyOfPurgeryField = value;
                this.RaisePropertyChanged("IsEsignPenaltyOfPurgery");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEsignPenaltyOfPurgerySpecified
        {
            get
            {
                return this.isEsignPenaltyOfPurgeryFieldSpecified;
            }
            set
            {
                this.isEsignPenaltyOfPurgeryFieldSpecified = value;
                this.RaisePropertyChanged("IsEsignPenaltyOfPurgerySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get
            {
                return this.isEsignChangeField;
            }
            set
            {
                this.isEsignChangeField = value;
                this.RaisePropertyChanged("IsEsignChange");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEsignChangeSpecified
        {
            get
            {
                return this.isEsignChangeFieldSpecified;
            }
            set
            {
                this.isEsignChangeFieldSpecified = value;
                this.RaisePropertyChanged("IsEsignChangeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get
            {
                return this.isEsignSettlementField;
            }
            set
            {
                this.isEsignSettlementField = value;
                this.RaisePropertyChanged("IsEsignSettlement");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEsignSettlementSpecified
        {
            get
            {
                return this.isEsignSettlementFieldSpecified;
            }
            set
            {
                this.isEsignSettlementFieldSpecified = value;
                this.RaisePropertyChanged("IsEsignSettlementSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode
        {
            get
            {
                return this.federalRenewalCodeField;
            }
            set
            {
                this.federalRenewalCodeField = value;
                this.RaisePropertyChanged("FederalRenewalCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get
            {
                return this.authorizedAccessEndDateField;
            }
            set
            {
                this.authorizedAccessEndDateField = value;
                this.RaisePropertyChanged("AuthorizedAccessEndDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AuthorizedAccessEndDateSpecified
        {
            get
            {
                return this.authorizedAccessEndDateFieldSpecified;
            }
            set
            {
                this.authorizedAccessEndDateFieldSpecified = value;
                this.RaisePropertyChanged("AuthorizedAccessEndDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get
            {
                return this.applicationRegistrationApplicationNumberField;
            }
            set
            {
                this.applicationRegistrationApplicationNumberField = value;
                this.RaisePropertyChanged("ApplicationRegistrationApplicationNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationRegistrationApplicationNumberSpecified
        {
            get
            {
                return this.applicationRegistrationApplicationNumberFieldSpecified;
            }
            set
            {
                this.applicationRegistrationApplicationNumberFieldSpecified = value;
                this.RaisePropertyChanged("ApplicationRegistrationApplicationNumberSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get
            {
                return this.isEsignField;
            }
            set
            {
                this.isEsignField = value;
                this.RaisePropertyChanged("IsEsign");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEsignSpecified
        {
            get
            {
                return this.isEsignFieldSpecified;
            }
            set
            {
                this.isEsignFieldSpecified = value;
                this.RaisePropertyChanged("IsEsignSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get
            {
                return this.isPhoneConsentField;
            }
            set
            {
                this.isPhoneConsentField = value;
                this.RaisePropertyChanged("IsPhoneConsent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPhoneConsentSpecified
        {
            get
            {
                return this.isPhoneConsentFieldSpecified;
            }
            set
            {
                this.isPhoneConsentFieldSpecified = value;
                this.RaisePropertyChanged("IsPhoneConsentSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode
        {
            get
            {
                return this.applyingForProgramCodeField;
            }
            set
            {
                this.applyingForProgramCodeField = value;
                this.RaisePropertyChanged("ApplyingForProgramCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get
            {
                return this.desiredCoverageDateField;
            }
            set
            {
                this.desiredCoverageDateField = value;
                this.RaisePropertyChanged("DesiredCoverageDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DesiredCoverageDateSpecified
        {
            get
            {
                return this.desiredCoverageDateFieldSpecified;
            }
            set
            {
                this.desiredCoverageDateFieldSpecified = value;
                this.RaisePropertyChanged("DesiredCoverageDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get
            {
                return this.isLossOfHealthCoverageField;
            }
            set
            {
                this.isLossOfHealthCoverageField = value;
                this.RaisePropertyChanged("IsLossOfHealthCoverage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsLossOfHealthCoverageSpecified
        {
            get
            {
                return this.isLossOfHealthCoverageFieldSpecified;
            }
            set
            {
                this.isLossOfHealthCoverageFieldSpecified = value;
                this.RaisePropertyChanged("IsLossOfHealthCoverageSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get
            {
                return this.hasMedicalBillsField;
            }
            set
            {
                this.hasMedicalBillsField = value;
                this.RaisePropertyChanged("HasMedicalBills");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMedicalBillsSpecified
        {
            get
            {
                return this.hasMedicalBillsFieldSpecified;
            }
            set
            {
                this.hasMedicalBillsFieldSpecified = value;
                this.RaisePropertyChanged("HasMedicalBillsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode
        {
            get
            {
                return this.optOutReasonCodeField;
            }
            set
            {
                this.optOutReasonCodeField = value;
                this.RaisePropertyChanged("OptOutReasonCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey
        {
            get
            {
                return this.preferredEmailForSurveyField;
            }
            set
            {
                this.preferredEmailForSurveyField = value;
                this.RaisePropertyChanged("PreferredEmailForSurvey");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get
            {
                return this.isUsingEmployerCoverageField;
            }
            set
            {
                this.isUsingEmployerCoverageField = value;
                this.RaisePropertyChanged("IsUsingEmployerCoverage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsUsingEmployerCoverageSpecified
        {
            get
            {
                return this.isUsingEmployerCoverageFieldSpecified;
            }
            set
            {
                this.isUsingEmployerCoverageFieldSpecified = value;
                this.RaisePropertyChanged("IsUsingEmployerCoverageSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get
            {
                return this.isEnrollmentESignField;
            }
            set
            {
                this.isEnrollmentESignField = value;
                this.RaisePropertyChanged("IsEnrollmentESign");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEnrollmentESignSpecified
        {
            get
            {
                return this.isEnrollmentESignFieldSpecified;
            }
            set
            {
                this.isEnrollmentESignFieldSpecified = value;
                this.RaisePropertyChanged("IsEnrollmentESignSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get
            {
                return this.isEnrollmentPhoneConsentField;
            }
            set
            {
                this.isEnrollmentPhoneConsentField = value;
                this.RaisePropertyChanged("IsEnrollmentPhoneConsent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEnrollmentPhoneConsentSpecified
        {
            get
            {
                return this.isEnrollmentPhoneConsentFieldSpecified;
            }
            set
            {
                this.isEnrollmentPhoneConsentFieldSpecified = value;
                this.RaisePropertyChanged("IsEnrollmentPhoneConsentSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get
            {
                return this.applicationDateField;
            }
            set
            {
                this.applicationDateField = value;
                this.RaisePropertyChanged("ApplicationDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationDateSpecified
        {
            get
            {
                return this.applicationDateFieldSpecified;
            }
            set
            {
                this.applicationDateFieldSpecified = value;
                this.RaisePropertyChanged("ApplicationDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get
            {
                return this.applicationTimeField;
            }
            set
            {
                this.applicationTimeField = value;
                this.RaisePropertyChanged("ApplicationTime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationTimeSpecified
        {
            get
            {
                return this.applicationTimeFieldSpecified;
            }
            set
            {
                this.applicationTimeFieldSpecified = value;
                this.RaisePropertyChanged("ApplicationTimeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode
        {
            get
            {
                return this.grossHeadofHouseholdIncomeFrequencyCodeField;
            }
            set
            {
                this.grossHeadofHouseholdIncomeFrequencyCodeField = value;
                this.RaisePropertyChanged("GrossHeadofHouseholdIncomeFrequencyCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get
            {
                return this.grossHeadOfHouseholdIncomeAmountField;
            }
            set
            {
                this.grossHeadOfHouseholdIncomeAmountField = value;
                this.RaisePropertyChanged("GrossHeadOfHouseholdIncomeAmount");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified
        {
            get
            {
                return this.grossHeadOfHouseholdIncomeAmountFieldSpecified;
            }
            set
            {
                this.grossHeadOfHouseholdIncomeAmountFieldSpecified = value;
                this.RaisePropertyChanged("GrossHeadOfHouseholdIncomeAmountSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get
            {
                return this.lastCaseActionDateField;
            }
            set
            {
                this.lastCaseActionDateField = value;
                this.RaisePropertyChanged("LastCaseActionDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastCaseActionDateSpecified
        {
            get
            {
                return this.lastCaseActionDateFieldSpecified;
            }
            set
            {
                this.lastCaseActionDateFieldSpecified = value;
                this.RaisePropertyChanged("LastCaseActionDateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode
        {
            get
            {
                return this.lastCaseActionCodeField;
            }
            set
            {
                this.lastCaseActionCodeField = value;
                this.RaisePropertyChanged("LastCaseActionCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser
        {
            get
            {
                return this.actionByUserField;
            }
            set
            {
                this.actionByUserField = value;
                this.RaisePropertyChanged("ActionByUser");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual
        {
            get
            {
                return this.applicationIndividualField;
            }
            set
            {
                this.applicationIndividualField = value;
                this.RaisePropertyChanged("ApplicationIndividual");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel
        {
            get
            {
                return this.nCPChildModelField;
            }
            set
            {
                this.nCPChildModelField = value;
                this.RaisePropertyChanged("NCPChildModel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails
        {
            get
            {
                return this.aPTCAnnualIncomeDetailsField;
            }
            set
            {
                this.aPTCAnnualIncomeDetailsField = value;
                this.RaisePropertyChanged("APTCAnnualIncomeDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative
        {
            get
            {
                return this.representativeField;
            }
            set
            {
                this.representativeField = value;
                this.RaisePropertyChanged("Representative");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments
        {
            get
            {
                return this.taskCommentsField;
            }
            set
            {
                this.taskCommentsField = value;
                this.RaisePropertyChanged("TaskComments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get
            {
                return this.voterRegistrationVisitedField;
            }
            set
            {
                this.voterRegistrationVisitedField = value;
                this.RaisePropertyChanged("VoterRegistrationVisited");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VoterRegistrationVisitedSpecified
        {
            get
            {
                return this.voterRegistrationVisitedFieldSpecified;
            }
            set
            {
                this.voterRegistrationVisitedFieldSpecified = value;
                this.RaisePropertyChanged("VoterRegistrationVisitedSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP
        {
            get
            {
                return this.deactivateNCPField;
            }
            set
            {
                this.deactivateNCPField = value;
                this.RaisePropertyChanged("DeactivateNCP");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Program", Order = 57)]
        public Program[] Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
                this.RaisePropertyChanged("Program");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent
        {
            get
            {
                return this.nonCustodialParentField;
            }
            set
            {
                this.nonCustodialParentField = value;
                this.RaisePropertyChanged("NonCustodialParent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 59)]
        public Conviction Conviction
        {
            get
            {
                return this.convictionField;
            }
            set
            {
                this.convictionField = value;
                this.RaisePropertyChanged("Conviction");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP
        {
            get
            {
                return this.expeditedSNAPField;
            }
            set
            {
                this.expeditedSNAPField = value;
                this.RaisePropertyChanged("ExpeditedSNAP");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor
        {
            get
            {
                return this.alienSponsorField;
            }
            set
            {
                this.alienSponsorField = value;
                this.RaisePropertyChanged("AlienSponsor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails
        {
            get
            {
                return this.dSNAPExpenseDetailsField;
            }
            set
            {
                this.dSNAPExpenseDetailsField = value;
                this.RaisePropertyChanged("DSNAPExpenseDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails
        {
            get
            {
                return this.dSNAPDisasterQuestionDetailsField;
            }
            set
            {
                this.dSNAPDisasterQuestionDetailsField = value;
                this.RaisePropertyChanged("DSNAPDisasterQuestionDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails
        {
            get
            {
                return this.dSNAPResourceDetailsField;
            }
            set
            {
                this.dSNAPResourceDetailsField = value;
                this.RaisePropertyChanged("DSNAPResourceDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get
            {
                return this.isNonMagiField;
            }
            set
            {
                this.isNonMagiField = value;
                this.RaisePropertyChanged("IsNonMagi");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsNonMagiSpecified
        {
            get
            {
                return this.isNonMagiFieldSpecified;
            }
            set
            {
                this.isNonMagiFieldSpecified = value;
                this.RaisePropertyChanged("IsNonMagiSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get
            {
                return this.isRACAddIndividualsField;
            }
            set
            {
                this.isRACAddIndividualsField = value;
                this.RaisePropertyChanged("IsRACAddIndividuals");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRACAddIndividualsSpecified
        {
            get
            {
                return this.isRACAddIndividualsFieldSpecified;
            }
            set
            {
                this.isRACAddIndividualsFieldSpecified = value;
                this.RaisePropertyChanged("IsRACAddIndividualsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation
        {
            get
            {
                return this.userCaseAssociationField;
            }
            set
            {
                this.userCaseAssociationField = value;
                this.RaisePropertyChanged("UserCaseAssociation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode
        {
            get
            {
                return this.portalCodeField;
            }
            set
            {
                this.portalCodeField = value;
                this.RaisePropertyChanged("PortalCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions
        {
            get
            {
                return this.resourceQuestionsField;
            }
            set
            {
                this.resourceQuestionsField = value;
                this.RaisePropertyChanged("ResourceQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions
        {
            get
            {
                return this.expenseQuestionsField;
            }
            set
            {
                this.expenseQuestionsField = value;
                this.RaisePropertyChanged("ExpenseQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation
        {
            get
            {
                return this.houseHoldSituationField;
            }
            set
            {
                this.houseHoldSituationField = value;
                this.RaisePropertyChanged("HouseHoldSituation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation
        {
            get
            {
                return this.userAttestationField;
            }
            set
            {
                this.userAttestationField = value;
                this.RaisePropertyChanged("UserAttestation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode
        {
            get
            {
                return this.caseOwnershipCodeField;
            }
            set
            {
                this.caseOwnershipCodeField = value;
                this.RaisePropertyChanged("CaseOwnershipCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun
        {
            get
            {
                return this.isEDBCToBeRunField;
            }
            set
            {
                this.isEDBCToBeRunField = value;
                this.RaisePropertyChanged("IsEDBCToBeRun");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly
        {
            get
            {
                return this.saveSubmitEarlyField;
            }
            set
            {
                this.saveSubmitEarlyField = value;
                this.RaisePropertyChanged("SaveSubmitEarly");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired
        {
            get
            {
                return this.isUpdateIndividualRequiredField;
            }
            set
            {
                this.isUpdateIndividualRequiredField = value;
                this.RaisePropertyChanged("IsUpdateIndividualRequired");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get
            {
                return this.taxReconcileIDField;
            }
            set
            {
                this.taxReconcileIDField = value;
                this.RaisePropertyChanged("TaxReconcileID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxReconcileIDSpecified
        {
            get
            {
                return this.taxReconcileIDFieldSpecified;
            }
            set
            {
                this.taxReconcileIDFieldSpecified = value;
                this.RaisePropertyChanged("TaxReconcileIDSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get
            {
                return this.hasBenefitsFromOtherStateField;
            }
            set
            {
                this.hasBenefitsFromOtherStateField = value;
                this.RaisePropertyChanged("HasBenefitsFromOtherState");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasBenefitsFromOtherStateSpecified
        {
            get
            {
                return this.hasBenefitsFromOtherStateFieldSpecified;
            }
            set
            {
                this.hasBenefitsFromOtherStateFieldSpecified = value;
                this.RaisePropertyChanged("HasBenefitsFromOtherStateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get
            {
                return this.hasSSIBenefitField;
            }
            set
            {
                this.hasSSIBenefitField = value;
                this.RaisePropertyChanged("HasSSIBenefit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasSSIBenefitSpecified
        {
            get
            {
                return this.hasSSIBenefitFieldSpecified;
            }
            set
            {
                this.hasSSIBenefitFieldSpecified = value;
                this.RaisePropertyChanged("HasSSIBenefitSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions
        {
            get
            {
                return this.incomeQuestionsField;
            }
            set
            {
                this.incomeQuestionsField = value;
                this.RaisePropertyChanged("IncomeQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get
            {
                return this.isSignedbyAuthorizedRepresentativeField;
            }
            set
            {
                this.isSignedbyAuthorizedRepresentativeField = value;
                this.RaisePropertyChanged("IsSignedbyAuthorizedRepresentative");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSignedbyAuthorizedRepresentativeSpecified
        {
            get
            {
                return this.isSignedbyAuthorizedRepresentativeFieldSpecified;
            }
            set
            {
                this.isSignedbyAuthorizedRepresentativeFieldSpecified = value;
                this.RaisePropertyChanged("IsSignedbyAuthorizedRepresentativeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get
            {
                return this.externalAuthorizedRepresentativeIdField;
            }
            set
            {
                this.externalAuthorizedRepresentativeIdField = value;
                this.RaisePropertyChanged("ExternalAuthorizedRepresentativeId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalAuthorizedRepresentativeIdSpecified
        {
            get
            {
                return this.externalAuthorizedRepresentativeIdFieldSpecified;
            }
            set
            {
                this.externalAuthorizedRepresentativeIdFieldSpecified = value;
                this.RaisePropertyChanged("ExternalAuthorizedRepresentativeIdSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 83)]
        //public AccountTransferInfo AccountTransferInformation
        //{
        //    get
        //    {
        //        return this.accountTransferInformationField;
        //    }
        //    set
        //    {
        //        this.accountTransferInformationField = value;
        //        this.RaisePropertyChanged("AccountTransferInformation");
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAddress", IsNullable = true, Order = 84)]
        public Address[] CaseAddress
        {
            get
            {
                return this.caseAddressField;
            }
            set
            {
                this.caseAddressField = value;
                this.RaisePropertyChanged("CaseAddress");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 85)]
        public SafetyQuestion SafetyQuestions
        {
            get
            {
                return this.safetyQuestionsField;
            }
            set
            {
                this.safetyQuestionsField = value;
                this.RaisePropertyChanged("SafetyQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 86)]
        public string SignedUserFirstName
        {
            get
            {
                return this.signedUserFirstNameField;
            }
            set
            {
                this.signedUserFirstNameField = value;
                this.RaisePropertyChanged("SignedUserFirstName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 87)]
        public string SignedUserLastName
        {
            get
            {
                return this.signedUserLastNameField;
            }
            set
            {
                this.signedUserLastNameField = value;
                this.RaisePropertyChanged("SignedUserLastName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 88)]
        public string SignedUserRole
        {
            get
            {
                return this.signedUserRoleField;
            }
            set
            {
                this.signedUserRoleField = value;
                this.RaisePropertyChanged("SignedUserRole");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 89)]
        public CareTakerSchedule CareTakerEnrollmentSchedule
        {
            get
            {
                return this.careTakerEnrollmentScheduleField;
            }
            set
            {
                this.careTakerEnrollmentScheduleField = value;
                this.RaisePropertyChanged("CareTakerEnrollmentSchedule");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterimConversionDetails", IsNullable = true, Order = 90)]
        public InterimConversionDetails[] InterimConversionDetails
        {
            get
            {
                return this.interimConversionDetailsField;
            }
            set
            {
                this.interimConversionDetailsField = value;
                this.RaisePropertyChanged("InterimConversionDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CcoSelections", IsNullable = true, Order = 91)]
        public CcoSelection[] CcoSelections
        {
            get
            {
                return this.ccoSelectionsField;
            }
            set
            {
                this.ccoSelectionsField = value;
                this.RaisePropertyChanged("CcoSelections");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 92)]
        public string IsToBeReferredToWic
        {
            get
            {
                return this.isToBeReferredToWicField;
            }
            set
            {
                this.isToBeReferredToWicField = value;
                this.RaisePropertyChanged("IsToBeReferredToWic");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 93)]
        public string PersonMakingApplicationCode
        {
            get
            {
                return this.personMakingApplicationCodeField;
            }
            set
            {
                this.personMakingApplicationCodeField = value;
                this.RaisePropertyChanged("PersonMakingApplicationCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 94)]
        public CommunityPartner CommunityParnterDetails
        {
            get
            {
                return this.communityParnterDetailsField;
            }
            set
            {
                this.communityParnterDetailsField = value;
                this.RaisePropertyChanged("CommunityParnterDetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 95)]
        public bool IsEstablishSnapFilingDate
        {
            get
            {
                return this.isEstablishSnapFilingDateField;
            }
            set
            {
                this.isEstablishSnapFilingDateField = value;
                this.RaisePropertyChanged("IsEstablishSnapFilingDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 96)]
        public string HasPartialAlienSponsorInformation
        {
            get
            {
                return this.hasPartialAlienSponsorInformationField;
            }
            set
            {
                this.hasPartialAlienSponsorInformationField = value;
                this.RaisePropertyChanged("HasPartialAlienSponsorInformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 97)]
        public int ApplicationSummaryRequestTriggerId
        {
            get
            {
                return this.applicationSummaryRequestTriggerIdField;
            }
            set
            {
                this.applicationSummaryRequestTriggerIdField = value;
                this.RaisePropertyChanged("ApplicationSummaryRequestTriggerId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 98)]
        public bool IsMidRecertificationFlow
        {
            get
            {
                return this.isMidRecertificationFlowField;
            }
            set
            {
                this.isMidRecertificationFlowField = value;
                this.RaisePropertyChanged("IsMidRecertificationFlow");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 99)]
        public bool IsMidRecertificationAndRenewal
        {
            get
            {
                return this.isMidRecertificationAndRenewalField;
            }
            set
            {
                this.isMidRecertificationAndRenewalField = value;
                this.RaisePropertyChanged("IsMidRecertificationAndRenewal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseMergeExcludedIndividuals", Order = 100)]
        public int[] CaseMergeExcludedIndividuals
        {
            get
            {
                return this.caseMergeExcludedIndividualsField;
            }
            set
            {
                this.caseMergeExcludedIndividualsField = value;
                this.RaisePropertyChanged("CaseMergeExcludedIndividuals");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 101)]
        public string SnapSrsComments
        {
            get
            {
                return this.snapSrsCommentsField;
            }
            set
            {
                this.snapSrsCommentsField = value;
                this.RaisePropertyChanged("SnapSrsComments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaskTypeComments", IsNullable = true, Order = 102)]
        public TaskTypeComments[] TaskTypeComments
        {
            get
            {
                return this.taskTypeCommentsField;
            }
            set
            {
                this.taskTypeCommentsField = value;
                this.RaisePropertyChanged("TaskTypeComments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 103)]
        public HouseholdQuestions HouseholdQuestions
        {
            get
            {
                return this.householdQuestionsField;
            }
            set
            {
                this.householdQuestionsField = value;
                this.RaisePropertyChanged("HouseholdQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 104)]
        public string IsSameContactInformation
        {
            get
            {
                return this.isSameContactInformationField;
            }
            set
            {
                this.isSameContactInformationField = value;
                this.RaisePropertyChanged("IsSameContactInformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", IsNullable = true, Order = 105)]
        public AdditionalInformation[] AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
                this.RaisePropertyChanged("AdditionalInformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 106)]
        public string IsUSVeteran
        {
            get
            {
                return this.isUSVeteranField;
            }
            set
            {
                this.isUSVeteranField = value;
                this.RaisePropertyChanged("IsUSVeteran");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 107)]
        public ScreenCategoryMapping ScreenCategoryMapping
        {
            get
            {
                return this.screenCategoryMappingField;
            }
            set
            {
                this.screenCategoryMappingField = value;
                this.RaisePropertyChanged("ScreenCategoryMapping");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 108)]
        public HouseholdQuestions CorrespondenceHouseholdQuestions
        {
            get
            {
                return this.correspondenceHouseholdQuestionsField;
            }
            set
            {
                this.correspondenceHouseholdQuestionsField = value;
                this.RaisePropertyChanged("CorrespondenceHouseholdQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 109)]
        public ResourceQuestions CorrespondenceResourceQuestions
        {
            get
            {
                return this.correspondenceResourceQuestionsField;
            }
            set
            {
                this.correspondenceResourceQuestionsField = value;
                this.RaisePropertyChanged("CorrespondenceResourceQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 110)]
        public IncomeQuestions CorrespondenceIncomeQuestions
        {
            get
            {
                return this.correspondenceIncomeQuestionsField;
            }
            set
            {
                this.correspondenceIncomeQuestionsField = value;
                this.RaisePropertyChanged("CorrespondenceIncomeQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 111)]
        public ExpenseQuestions CorrespondenceExpenseQuestions
        {
            get
            {
                return this.correspondenceExpenseQuestionsField;
            }
            set
            {
                this.correspondenceExpenseQuestionsField = value;
                this.RaisePropertyChanged("CorrespondenceExpenseQuestions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 112)]
        public System.Nullable<int> DisasterPeriodId
        {
            get
            {
                return this.disasterPeriodIdField;
            }
            set
            {
                this.disasterPeriodIdField = value;
                this.RaisePropertyChanged("DisasterPeriodId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 113)]
        public string CovidEmergencyExist
        {
            get
            {
                return this.covidEmergencyExistField;
            }
            set
            {
                this.covidEmergencyExistField = value;
                this.RaisePropertyChanged("CovidEmergencyExist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 114)]
        public int ApplicationSummaryProcessingId
        {
            get
            {
                return this.applicationSummaryProcessingIdField;
            }
            set
            {
                this.applicationSummaryProcessingIdField = value;
                this.RaisePropertyChanged("ApplicationSummaryProcessingId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildWithCustodialParents", Order = 115)]
        public int[] ChildWithCustodialParents
        {
            get
            {
                return this.childWithCustodialParentsField;
            }
            set
            {
                this.childWithCustodialParentsField = value;
                this.RaisePropertyChanged("ChildWithCustodialParents");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrepopulatedIndividuals", Order = 116)]
        public int[] PrepopulatedIndividuals
        {
            get
            {
                return this.prepopulatedIndividualsField;
            }
            set
            {
                this.prepopulatedIndividualsField = value;
                this.RaisePropertyChanged("PrepopulatedIndividuals");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 117)]
        public System.Nullable<System.DateTime> DisabilityDemographicsDate
        {
            get
            {
                return this.disabilityDemographicsDateField;
            }
            set
            {
                this.disabilityDemographicsDateField = value;
                this.RaisePropertyChanged("DisabilityDemographicsDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 118)]
        public System.Nullable<System.DateTime> RaceEthnicityDate
        {
            get
            {
                return this.raceEthnicityDateField;
            }
            set
            {
                this.raceEthnicityDateField = value;
                this.RaisePropertyChanged("RaceEthnicityDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 119)]
        public System.Nullable<System.DateTime> LanguageCommunicationDate
        {
            get
            {
                return this.languageCommunicationDateField;
            }
            set
            {
                this.languageCommunicationDateField = value;
                this.RaisePropertyChanged("LanguageCommunicationDate");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class submitApplicationChangeAddressResponseSubmitApplicationChangeAddressResult : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ResponseType responseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ResponseType Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
                this.RaisePropertyChanged("Response");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class determineEligibilityApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class determineEligibilityResponseDetermineEligibilityResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class addNewBornApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class addNewBornResponseAddNewBornResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "createTask", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class createTaskRequest
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task { get; set; }

        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 1)]
        [XmlArrayItemAttribute(IsNullable = false)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "createTaskResponse", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class createTaskResponse
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        public int createTaskResult { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "CreateTasks", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class CreateTasksRequest
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task { get; set; }

        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 1)]
        [XmlArrayItemAttribute(IsNullable = false)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes { get; set; }
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 2)]
        [XmlArrayItemAttribute(IsNullable = false)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskPrimaryAttribute[] taskPrimaryAttributes { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "CreateTasksResponse", WrapperNamespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", IsWrapped = true)]
    public class CreateTasksResponse
    {
        [MessageBodyMemberAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd", Order = 0)]
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskResponseModel CreateTasksResult { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitIndividualRelationshipsResponseSubmitIndividualRelationshipsResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitPreCaseApplicationApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitPreCaseApplicationResponseSubmitPreCaseApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitDCApplicationApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitDCApplicationResponseSubmitDCApplicationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public class SSPDCIntegrationServiceClient : System.ServiceModel.ClientBase<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService>, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService
    {
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationResponseSubmitApplicationResult submitApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitApplication(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationResponseSubmitApplicationResult> submitApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitApplicationAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationForPrepopulatedDataResponseSubmitApplicationForPrepopulatedDataResult submitApplicationForPrepopulatedData(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitApplicationForPrepopulatedData(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationForPrepopulatedDataResponseSubmitApplicationForPrepopulatedDataResult> submitApplicationForPrepopulatedDataAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitApplicationForPrepopulatedDataAsync(Application);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitSNAPShortApplicationResponseSubmitSNAPShortApplicationResult submitSNAPShortApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitSNAPShortApplication(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitSNAPShortApplicationResponseSubmitSNAPShortApplicationResult> submitSNAPShortApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitSNAPShortApplicationAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitDisasterSNAPApplicationResponseSubmitDisasterSNAPApplicationResult submitDisasterSNAPApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitDisasterSNAPApplication(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitDisasterSNAPApplicationResponseSubmitDisasterSNAPApplicationResult> submitDisasterSNAPApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application Application)
        {
            return base.Channel.submitDisasterSNAPApplicationAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponseReRunApplicationResult ReRunApplication(System.Nullable<int> applicationNumber, System.Nullable<int> caseNumber, System.Nullable<int> processingID, bool isFileClearanceRerun)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest();
            inValue.applicationNumber = applicationNumber;
            inValue.caseNumber = caseNumber;
            inValue.processingID = processingID;
            inValue.isFileClearanceRerun = isFileClearanceRerun;
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponse retVal = ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).ReRunApplication(inValue);
            return retVal.ReRunApplicationResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponse> Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService.ReRunApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest request)
        {
            return base.Channel.ReRunApplicationAsync(request);
        }
        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationResponse> ReRunApplicationAsync(System.Nullable<int> applicationNumber, System.Nullable<int> caseNumber, System.Nullable<int> processingID, bool isFileClearanceRerun)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ReRunApplicationRequest();
            inValue.applicationNumber = applicationNumber;
            inValue.caseNumber = caseNumber;
            inValue.processingID = processingID;
            inValue.isFileClearanceRerun = isFileClearanceRerun;
            return ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).ReRunApplicationAsync(inValue);
        }

        public bool removalOfMAAssisstance(int individualId, int caseNumber)
        {
            return base.Channel.removalOfMAAssisstance(individualId, caseNumber);
        }

        public System.Threading.Tasks.Task<bool> removalOfMAAssisstanceAsync(int individualId, int caseNumber)
        {
            return base.Channel.removalOfMAAssisstanceAsync(individualId, caseNumber);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEResponseSubmitPEResult SubmitPE(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEApplication Application)
        {
            return base.Channel.SubmitPE(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEResponseSubmitPEResult> SubmitPEAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPEApplication Application)
        {
            return base.Channel.SubmitPEAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitAdditionalApplicationDetailsResponseSubmitAdditionalApplicationDetailsResult SubmitAdditionalApplicationDetails(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.AdditionalApplicationDetails additionalApplicationDetails)
        {
            return base.Channel.SubmitAdditionalApplicationDetails(additionalApplicationDetails);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitAdditionalApplicationDetailsResponseSubmitAdditionalApplicationDetailsResult> SubmitAdditionalApplicationDetailsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.AdditionalApplicationDetails additionalApplicationDetails)
        {
            return base.Channel.SubmitAdditionalApplicationDetailsAsync(additionalApplicationDetails);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeResponseSubmitApplicationChangeResult submitApplicationChange(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication oldXML, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication newXML)
        {
            return base.Channel.submitApplicationChange(Application, oldXML, newXML);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeResponseSubmitApplicationChangeResult> submitApplicationChangeAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication oldXML, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication newXML)
        {
            return base.Channel.submitApplicationChangeAsync(Application, oldXML, newXML);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeAddressResponseSubmitApplicationChangeAddressResult submitApplicationChangeAddress(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application)
        {
            return base.Channel.submitApplicationChangeAddress(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.submitApplicationChangeAddressResponseSubmitApplicationChangeAddressResult> submitApplicationChangeAddressAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication Application)
        {
            return base.Channel.submitApplicationChangeAddressAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityResponseDetermineEligibilityResult determineEligibility(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityApplication Application)
        {
            return base.Channel.determineEligibility(Application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityResponseDetermineEligibilityResult> determineEligibilityAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.determineEligibilityApplication Application)
        {
            return base.Channel.determineEligibilityAsync(Application);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornResponseAddNewBornResult addNewBorn(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornApplication application)
        {
            return base.Channel.addNewBorn(application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornResponseAddNewBornResult> addNewBornAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.addNewBornApplication application)
        {
            return base.Channel.addNewBornAsync(application);
        }

        public bool updateAgency(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation agencyInput, string Operation)
        {
            return base.Channel.updateAgency(agencyInput, Operation);
        }

        public System.Threading.Tasks.Task<bool> updateAgencyAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation agencyInput, string Operation)
        {
            return base.Channel.updateAgencyAsync(agencyInput, Operation);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService.createTask(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest request)
        {
            return base.Channel.createTask(request);
        }
        public int createTask(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest();
            inValue.task = task;
            inValue.taskAttributes = taskAttributes;
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse retVal = ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).createTask(inValue);
            return retVal.createTaskResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse> Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService.createTaskAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest request)
        {
            return base.Channel.createTaskAsync(request);
        }
        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskResponse> createTaskAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.createTaskRequest();
            inValue.task = task;
            inValue.taskAttributes = taskAttributes;
            return ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).createTaskAsync(inValue);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService.CreateTasks(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest request)
        {
            return base.Channel.CreateTasks(request);
        }
        public bool UpdateTasks(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel tasks)
        {
            return base.Channel.UpdateTasks(tasks);
        }

        public System.Threading.Tasks.Task<bool> UpdateTasksAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel tasks)
        {
            return base.Channel.UpdateTasksAsync(tasks);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskResponseModel CreateTasks(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskPrimaryAttribute[] taskPrimaryAttributes)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest();
            inValue.task = task;
            inValue.taskAttributes = taskAttributes;
            inValue.taskPrimaryAttributes = taskPrimaryAttributes;
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse retVal = ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).CreateTasks(inValue);
            return retVal.CreateTasksResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse> Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService.CreateTasksAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest request)
        {
            return base.Channel.CreateTasksAsync(request);
        }
        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksResponse> CreateTasksAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskModel task, Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaskAttributes[] taskAttributes)
        {
            Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest inValue = new Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.CreateTasksRequest();
            inValue.task = task;
            inValue.taskAttributes = taskAttributes;
            return ((Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ISSPDCIntegrationService)(this)).CreateTasksAsync(inValue);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[] CalculateMaxAPTC(int caseNumber, int coverageYear)
        {
            return base.Channel.CalculateMaxAPTC(caseNumber, coverageYear);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[]> CalculateMaxAPTCAsync(int caseNumber, int coverageYear)
        {
            return base.Channel.CalculateMaxAPTCAsync(caseNumber, coverageYear);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[] CalculateMaxAPTCWithUserRole(int caseNumber, int coverageYear, string userRole)
        {
            return base.Channel.CalculateMaxAPTCWithUserRole(caseNumber, coverageYear, userRole);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.MaxAPTCResponse[]> CalculateMaxAPTCWithUserRoleAsync(int caseNumber, int coverageYear, string userRole)
        {
            return base.Channel.CalculateMaxAPTCWithUserRoleAsync(caseNumber, coverageYear, userRole);
        }

        public bool UpdateIndividualMCI(int individualid, int mciID)
        {
            return base.Channel.UpdateIndividualMCI(individualid, mciID);
        }

        public System.Threading.Tasks.Task<bool> UpdateIndividualMCIAsync(int individualid, int mciID)
        {
            return base.Channel.UpdateIndividualMCIAsync(individualid, mciID);
        }

        public void ToggleDownTimeStatus(string availabilityStatus)
        {
            base.Channel.ToggleDownTimeStatus(availabilityStatus);
        }

        public System.Threading.Tasks.Task ToggleDownTimeStatusAsync(string availabilityStatus)
        {
            return base.Channel.ToggleDownTimeStatusAsync(availabilityStatus);
        }

        public string GeteDownTimeStatus()
        {
            return base.Channel.GeteDownTimeStatus();
        }

        public System.Threading.Tasks.Task<string> GeteDownTimeStatusAsync()
        {
            return base.Channel.GeteDownTimeStatusAsync();
        }

        public bool UpdateContactDetails(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Individual individualDetails, int caseNumber)
        {
            return base.Channel.UpdateContactDetails(individualDetails, caseNumber);
        }

        public System.Threading.Tasks.Task<bool> UpdateContactDetailsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Individual individualDetails, int caseNumber)
        {
            return base.Channel.UpdateContactDetailsAsync(individualDetails, caseNumber);
        }
        public ReRunApplicationResponse ReRunApplication(ReRunApplicationRequest request)
        {
            return base.Channel.ReRunApplication(request);
        }
        public System.Threading.Tasks.Task<ReRunApplicationResponse> ReRunApplicationAsync(ReRunApplicationRequest request)
        {
            return base.Channel.ReRunApplicationAsync(request);
        }
        public createTaskResponse createTask(createTaskRequest request)
        {
            return base.Channel.createTask(request);
        }
        public System.Threading.Tasks.Task<createTaskResponse> createTaskAsync(createTaskRequest request)
        {
            return base.Channel.createTaskAsync(request);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitIndividualRelationshipsResponseSubmitIndividualRelationshipsResult SubmitIndividualRelationships(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.IndividualRelationships indivRelationships)
        {
            return base.Channel.SubmitIndividualRelationships(indivRelationships);
        }
        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitIndividualRelationshipsResponseSubmitIndividualRelationshipsResult> SubmitIndividualRelationshipsAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.IndividualRelationships indivRelationships)
        {
            return base.Channel.SubmitIndividualRelationshipsAsync(indivRelationships);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaxFilerModel[] GetTaxFilerList(int casenumber)
        {
            return base.Channel.GetTaxFilerList(casenumber);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.TaxFilerModel[]> GetTaxFilerListAsync(int casenumber)
        {
            return base.Channel.GetTaxFilerListAsync(casenumber);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.HouseholdCompositionReturnModel PopulateHouseholdComposition(int casenumber)
        {
            return base.Channel.PopulateHouseholdComposition(casenumber);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.HouseholdCompositionReturnModel> PopulateHouseholdCompositionAsync(int casenumber)
        {
            return base.Channel.PopulateHouseholdCompositionAsync(casenumber);
        }
        public int GetCaseNumber(int IndividualId)
        {
            return base.Channel.GetCaseNumber(IndividualId);
        }

        public System.Threading.Tasks.Task<int> GetCaseNumberAsync(int IndividualId)
        {
            return base.Channel.GetCaseNumberAsync(IndividualId);
        }
        public bool InsertOrganizationCase(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation organizaionInput)
        {
            return base.Channel.InsertOrganizationCase(organizaionInput);
        }

        public System.Threading.Tasks.Task<bool> InsertOrganizationCaseAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.DCAgencyIndividualCaseAssociation organizaionInput)
        {
            return base.Channel.InsertOrganizationCaseAsync(organizaionInput);
        }
        public bool SaveAPTCReview(int CaseNumber, string UserRole, string IsReviewSelected, string SpecializedFlag)
        {
            return base.Channel.SaveAPTCReview(CaseNumber, UserRole, IsReviewSelected, SpecializedFlag);
        }

        public System.Threading.Tasks.Task<bool> SaveAPTCReviewAsync(int CaseNumber, string UserRole, string IsReviewSelected, string SpecializedFlag)
        {
            return base.Channel.SaveAPTCReviewAsync(CaseNumber, UserRole, IsReviewSelected, SpecializedFlag);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPreCaseApplicationResponseSubmitPreCaseApplicationResult SubmitPreCaseApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application)
        {
            return base.Channel.SubmitPreCaseApplication(application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitPreCaseApplicationResponseSubmitPreCaseApplicationResult> SubmitPreCaseApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application)
        {
            return base.Channel.SubmitPreCaseApplicationAsync(application);
        }
        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCApplicationResponseSubmitDCApplicationResult SubmitDCApplication(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application, int ProcessingID)
        {
            return base.Channel.SubmitDCApplication(application, ProcessingID);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCApplicationResponseSubmitDCApplicationResult> SubmitDCApplicationAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.Application application, int ProcessingID)
        {
            return base.Channel.SubmitDCApplicationAsync(application, ProcessingID);
        }

        public Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCRepresentativeInfoResponseSubmitDCRepresentativeInfoResult SubmitDCRepresentativeInfo(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication application)
        {
            return base.Channel.SubmitDCRepresentativeInfo(application);
        }

        public System.Threading.Tasks.Task<Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.SubmitDCRepresentativeInfoResponseSubmitDCRepresentativeInfoResult> SubmitDCRepresentativeInfoAsync(Ky.Hbe.IntegrationServices.SelfService.Contracts.SSPDCClient.ChangeApplication application)
        {
            return base.Channel.SubmitDCRepresentativeInfoAsync(application);
        }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitDCRepresentativeInfoApplication : controlInfo
    {
        [XmlElementAttribute(IsNullable = true, Order = 0)]
        public PreviousCaseDetails PreviousCaseDetail { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public Renewals Renewals { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TaskErrorCode { get; set; }

        [XmlElementAttribute(Order = 3)]
        public int ApplicationNumber { get; set; }

        [XmlElementAttribute(Order = 4)]
        public int SSPApplicationNumber { get; set; }

        protected System.Nullable<int> _CaseNumber;

        [XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<int> CaseNumber
        {
            get { return _CaseNumber; }
            set
            {
                _CaseNumber = value;
                CaseNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool CaseNumberSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationReceivedDate;

        [XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> ApplicationReceivedDate
        {
            get { return _ApplicationReceivedDate; }
            set
            {
                _ApplicationReceivedDate = value;
                ApplicationReceivedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationReceivedDateSpecified { get; set; }

        [XmlElementAttribute(Order = 7)]
        public string ApplicationStatusCode { get; set; }

        [XmlElementAttribute(Order = 8)]
        public string ApplicationSource { get; set; }

        [XmlElementAttribute(Order = 9)]
        public string Source { get; set; }

        protected System.Nullable<bool> _IsEDBCAlreadyExecuted;

        [XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> IsEDBCAlreadyExecuted
        {
            get { return _IsEDBCAlreadyExecuted; }
            set
            {
                _IsEDBCAlreadyExecuted = value;
                IsEDBCAlreadyExecutedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEDBCAlreadyExecutedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsExpedited;

        [XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<YesNoType> IsExpedited
        {
            get { return _IsExpedited; }
            set
            {
                _IsExpedited = value;
                IsExpeditedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsExpeditedSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsScheduled;

        [XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<YesNoType> IsScheduled
        {
            get { return _IsScheduled; }
            set
            {
                _IsScheduled = value;
                IsScheduledSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsScheduledSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ExpeditedDeterminedDate;

        [XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> ExpeditedDeterminedDate
        {
            get { return _ExpeditedDeterminedDate; }
            set
            {
                _ExpeditedDeterminedDate = value;
                ExpeditedDeterminedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExpeditedDeterminedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _StatusUpdatedDate;

        [XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.DateTime> StatusUpdatedDate
        {
            get { return _StatusUpdatedDate; }
            set
            {
                _StatusUpdatedDate = value;
                StatusUpdatedDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool StatusUpdatedDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationStatusDate;

        [XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.DateTime> ApplicationStatusDate
        {
            get { return _ApplicationStatusDate; }
            set
            {
                _ApplicationStatusDate = value;
                ApplicationStatusDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationStatusDateSpecified { get; set; }

        [XmlElementAttribute(Order = 16)]
        public string ApplicationModeCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public string ProgramAddIndicator { get; set; }

        protected System.Nullable<int> _OfficeNumber;

        [XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<int> OfficeNumber
        {
            get { return _OfficeNumber; }
            set
            {
                _OfficeNumber = value;
                OfficeNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool OfficeNumberSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 19)]
        public string ApplicationWrittenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 20)]
        public string ApplicationSpokenLanguageCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 21)]
        public string ApplicationSpecialAccomodationCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 22)]
        public string ApplicationSourceCode { get; set; }

        [XmlElementAttribute(Order = 23)]
        public string ProgramCode { get; set; }

        [XmlElementAttribute(Order = 24)]
        public YesNoType IsFinancialAssistanceNeeded { get; set; }

        [XmlElementAttribute(Order = 25)]
        public YesNoType IsApplicantAuthorizedRepresentative { get; set; }

        protected System.Nullable<YesNoType> _IsEsignPenaltyOfPurgery;

        [XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<YesNoType> IsEsignPenaltyOfPurgery
        {
            get { return _IsEsignPenaltyOfPurgery; }
            set
            {
                _IsEsignPenaltyOfPurgery = value;
                IsEsignPenaltyOfPurgerySpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignPenaltyOfPurgerySpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignChange;

        [XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<YesNoType> IsEsignChange
        {
            get { return _IsEsignChange; }
            set
            {
                _IsEsignChange = value;
                IsEsignChangeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignChangeSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsignSettlement;

        [XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<YesNoType> IsEsignSettlement
        {
            get { return _IsEsignSettlement; }
            set
            {
                _IsEsignSettlement = value;
                IsEsignSettlementSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSettlementSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 29)]
        public string FederalRenewalCode { get; set; }

        protected System.Nullable<System.DateTime> _AuthorizedAccessEndDate;

        [XmlElementAttribute(IsNullable = true, Order = 30)]
        public System.Nullable<System.DateTime> AuthorizedAccessEndDate
        {
            get { return _AuthorizedAccessEndDate; }
            set
            {
                _AuthorizedAccessEndDate = value;
                AuthorizedAccessEndDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool AuthorizedAccessEndDateSpecified { get; set; }

        protected System.Nullable<int> _ApplicationRegistrationApplicationNumber;

        [XmlElementAttribute(IsNullable = true, Order = 31)]
        public System.Nullable<int> ApplicationRegistrationApplicationNumber
        {
            get { return _ApplicationRegistrationApplicationNumber; }
            set
            {
                _ApplicationRegistrationApplicationNumber = value;
                ApplicationRegistrationApplicationNumberSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationRegistrationApplicationNumberSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEsign;

        [XmlElementAttribute(IsNullable = true, Order = 32)]
        public System.Nullable<YesNoType> IsEsign
        {
            get { return _IsEsign; }
            set
            {
                _IsEsign = value;
                IsEsignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEsignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<YesNoType> IsPhoneConsent
        {
            get { return _IsPhoneConsent; }
            set
            {
                _IsPhoneConsent = value;
                IsPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsPhoneConsentSpecified { get; set; }

        [XmlElementAttribute("ApplyingForProgramCode", IsNullable = true, Order = 34)]
        public string[] ApplyingForProgramCode { get; set; }

        protected System.Nullable<System.DateTime> _DesiredCoverageDate;

        [XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<System.DateTime> DesiredCoverageDate
        {
            get { return _DesiredCoverageDate; }
            set
            {
                _DesiredCoverageDate = value;
                DesiredCoverageDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool DesiredCoverageDateSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsLossOfHealthCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 36)]
        public System.Nullable<YesNoType> IsLossOfHealthCoverage
        {
            get { return _IsLossOfHealthCoverage; }
            set
            {
                _IsLossOfHealthCoverage = value;
                IsLossOfHealthCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsLossOfHealthCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasMedicalBills;

        [XmlElementAttribute(IsNullable = true, Order = 37)]
        public System.Nullable<YesNoType> HasMedicalBills
        {
            get { return _HasMedicalBills; }
            set
            {
                _HasMedicalBills = value;
                HasMedicalBillsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasMedicalBillsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 38)]
        public string OptOutReasonCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 39)]
        public string PreferredEmailForSurvey { get; set; }

        protected System.Nullable<YesNoType> _IsUsingEmployerCoverage;

        [XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<YesNoType> IsUsingEmployerCoverage
        {
            get { return _IsUsingEmployerCoverage; }
            set
            {
                _IsUsingEmployerCoverage = value;
                IsUsingEmployerCoverageSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsUsingEmployerCoverageSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentESign;

        [XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<YesNoType> IsEnrollmentESign
        {
            get { return _IsEnrollmentESign; }
            set
            {
                _IsEnrollmentESign = value;
                IsEnrollmentESignSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentESignSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsEnrollmentPhoneConsent;

        [XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<YesNoType> IsEnrollmentPhoneConsent
        {
            get { return _IsEnrollmentPhoneConsent; }
            set
            {
                _IsEnrollmentPhoneConsent = value;
                IsEnrollmentPhoneConsentSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsEnrollmentPhoneConsentSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationDate;

        [XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<System.DateTime> ApplicationDate
        {
            get { return _ApplicationDate; }
            set
            {
                _ApplicationDate = value;
                ApplicationDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationDateSpecified { get; set; }

        protected System.Nullable<System.DateTime> _ApplicationTime;

        [XmlElementAttribute(IsNullable = true, Order = 44)]
        public System.Nullable<System.DateTime> ApplicationTime
        {
            get { return _ApplicationTime; }
            set
            {
                _ApplicationTime = value;
                ApplicationTimeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ApplicationTimeSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 45)]
        public string GrossHeadofHouseholdIncomeFrequencyCode { get; set; }

        protected System.Nullable<decimal> _GrossHeadOfHouseholdIncomeAmount;

        [XmlElementAttribute(IsNullable = true, Order = 46)]
        public System.Nullable<decimal> GrossHeadOfHouseholdIncomeAmount
        {
            get { return _GrossHeadOfHouseholdIncomeAmount; }
            set
            {
                _GrossHeadOfHouseholdIncomeAmount = value;
                GrossHeadOfHouseholdIncomeAmountSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool GrossHeadOfHouseholdIncomeAmountSpecified { get; set; }

        protected System.Nullable<System.DateTime> _LastCaseActionDate;

        [XmlElementAttribute(IsNullable = true, Order = 47)]
        public System.Nullable<System.DateTime> LastCaseActionDate
        {
            get { return _LastCaseActionDate; }
            set
            {
                _LastCaseActionDate = value;
                LastCaseActionDateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool LastCaseActionDateSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 48)]
        public string LastCaseActionCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 49)]
        public string ActionByUser { get; set; }

        [XmlElementAttribute("ApplicationIndividual", Order = 50)]
        public ApplicationIndividual[] ApplicationIndividual { get; set; }

        [XmlElementAttribute("NCPChildModel", Order = 51)]
        public NCPChildModel[] NCPChildModel { get; set; }

        [XmlElementAttribute("APTCAnnualIncomeDetails", IsNullable = true, Order = 52)]
        public APTCAnnualIncome[] APTCAnnualIncomeDetails { get; set; }

        [XmlElementAttribute("Representative", Order = 53)]
        public Representative[] Representative { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 54)]
        public string TaskComments { get; set; }

        protected System.Nullable<YesNoType> _VoterRegistrationVisited;

        [XmlElementAttribute(IsNullable = true, Order = 55)]
        public System.Nullable<YesNoType> VoterRegistrationVisited
        {
            get { return _VoterRegistrationVisited; }
            set
            {
                _VoterRegistrationVisited = value;
                VoterRegistrationVisitedSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool VoterRegistrationVisitedSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 56)]
        public System.Nullable<YesNoType> DeactivateNCP { get; set; }

        [XmlElementAttribute("Program", Order = 57)]
        public Program[] Program { get; set; }

        [XmlElementAttribute("NonCustodialParent", Order = 58)]
        public NonCustodialParent[] NonCustodialParent { get; set; }

        [XmlElementAttribute(Order = 59)]
        public Conviction Conviction { get; set; }

        [XmlElementAttribute(Order = 60)]
        public ExpeditedSNAP ExpeditedSNAP { get; set; }

        [XmlElementAttribute("AlienSponsor", Order = 61)]
        public AlienSponsor[] AlienSponsor { get; set; }

        [XmlElementAttribute(Order = 62)]
        public DSNAPExpenseDetails DSNAPExpenseDetails { get; set; }

        [XmlElementAttribute(Order = 63)]
        public DSNAPDisasterQuestionDetails DSNAPDisasterQuestionDetails { get; set; }

        [XmlElementAttribute("DSNAPResourceDetails", Order = 64)]
        public DSNAPResourceDetails[] DSNAPResourceDetails { get; set; }

        protected System.Nullable<YesNoType> _IsNonMagi;

        [XmlElementAttribute(IsNullable = true, Order = 65)]
        public System.Nullable<YesNoType> IsNonMagi
        {
            get { return _IsNonMagi; }
            set
            {
                _IsNonMagi = value;
                IsNonMagiSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsNonMagiSpecified { get; set; }

        protected System.Nullable<YesNoType> _IsRACAddIndividuals;

        [XmlElementAttribute(IsNullable = true, Order = 66)]
        public System.Nullable<YesNoType> IsRACAddIndividuals
        {
            get { return _IsRACAddIndividuals; }
            set
            {
                _IsRACAddIndividuals = value;
                IsRACAddIndividualsSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsRACAddIndividualsSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 67)]
        public UserCaseAssociation UserCaseAssociation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string PortalCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public ResourceQuestions ResourceQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 70)]
        public ExpenseQuestions ExpenseQuestions { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 71)]
        public HouseHoldSituation HouseHoldSituation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 72)]
        public string UserAttestation { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 73)]
        public string CaseOwnershipCode { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 74)]
        public string IsEDBCToBeRun { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 75)]
        public string SaveSubmitEarly { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 76)]
        public string IsUpdateIndividualRequired { get; set; }

        protected System.Nullable<int> _TaxReconcileID;

        [XmlElementAttribute(IsNullable = true, Order = 77)]
        public System.Nullable<int> TaxReconcileID
        {
            get { return _TaxReconcileID; }
            set
            {
                _TaxReconcileID = value;
                TaxReconcileIDSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool TaxReconcileIDSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasBenefitsFromOtherState;

        [XmlElementAttribute(IsNullable = true, Order = 78)]
        public System.Nullable<YesNoType> HasBenefitsFromOtherState
        {
            get { return _HasBenefitsFromOtherState; }
            set
            {
                _HasBenefitsFromOtherState = value;
                HasBenefitsFromOtherStateSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasBenefitsFromOtherStateSpecified { get; set; }

        protected System.Nullable<YesNoType> _HasSSIBenefit;

        [XmlElementAttribute(IsNullable = true, Order = 79)]
        public System.Nullable<YesNoType> HasSSIBenefit
        {
            get { return _HasSSIBenefit; }
            set
            {
                _HasSSIBenefit = value;
                HasSSIBenefitSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool HasSSIBenefitSpecified { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 80)]
        public IncomeQuestions IncomeQuestions { get; set; }

        protected System.Nullable<YesNoType> _IsSignedbyAuthorizedRepresentative;

        [XmlElementAttribute(IsNullable = true, Order = 81)]
        public System.Nullable<YesNoType> IsSignedbyAuthorizedRepresentative
        {
            get { return _IsSignedbyAuthorizedRepresentative; }
            set
            {
                _IsSignedbyAuthorizedRepresentative = value;
                IsSignedbyAuthorizedRepresentativeSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool IsSignedbyAuthorizedRepresentativeSpecified { get; set; }

        protected System.Nullable<int> _ExternalAuthorizedRepresentativeId;

        [XmlElementAttribute(IsNullable = true, Order = 82)]
        public System.Nullable<int> ExternalAuthorizedRepresentativeId
        {
            get { return _ExternalAuthorizedRepresentativeId; }
            set
            {
                _ExternalAuthorizedRepresentativeId = value;
                ExternalAuthorizedRepresentativeIdSpecified = true;
            }
        }

        [XmlIgnoreAttribute]
        public bool ExternalAuthorizedRepresentativeIdSpecified { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SubmitDCRepresentativeInfoResponseSubmitDCRepresentativeInfoResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public ResponseType Response { get; set; }
    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SafetyQuestion : controlInfo
    {

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public YesNoType? NeedPlaceToLive { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public YesNoType? EvictionForeClosureNotice { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public YesNoType? UtilityShutOffNotice { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public YesNoType? CashBenefitsforChildren { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public YesNoType? IsDomesticViolenceVictim { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public YesNoType? IsPartnerThreatening { get; set; }
    }

    //Author : Vaibhav
    //Date : 31 August 2017
    //Comments : New SSP Model for CCO Selection Screen
    #region CCO Selection
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualCCOCodes
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int IndividualID { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int SakID { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CCOCodeDescription { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string WebsiteLink { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ReasonForCCOChangeCode { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class IndividualEligibilityResult
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int IndividualID { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MemberName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ProgramCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string IndividualEligibility { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public IndividualCCOCodes[] lstIndividualCCOCodes { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string EligibilityStartDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string EligibilityEndDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string EdgStatusCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string SelectedCCOID { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public int EdgTraceId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CurrentEligibilityIndicator { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public int disposedRecordsCount { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string IsDisposed { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string TypeOfAssistanceCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string BenefitLevel { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string IsAIAN { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CCOSelectionViewModel
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IndividualEligibilityResult[] EligibilityResultSet { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int ApprovedRecordsCount { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int PendingRecordsCount { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string RedirectToHomePageReason { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public bool? IsKeepCurrentCCO { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ReviewStatusCode { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class IndividualDisability : controlInfo
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public string IsDeaf { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string IsDeafAge { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IsBlind { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public string IsBlindAge { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public string DisabledMemory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public string DisabledMemoryAge { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public string DisabledWalking { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public string DisabledWalkingAge { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string DisabledDressing { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public string DisabledDressingAge { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public string DisabledErrands { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public string DisabledErrandsAge { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public string IsLimited { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public string IndividualId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public string ActivityLimitAge { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public string HasDyslexia { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public string HasDyslexiaAge { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public string HasAphasia { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public string HasAphasiaAge { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public string HasPsychosis { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public string HasPsychosisAge { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class ResourceTrustIndividual : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public int? IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public int? ResourceId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string IndividualCategory { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public string OtherBeneficiaryGrantorType { get; set; }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public partial class AccidentInjuryDetails : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 0)]
        public int IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public int? CasualtyId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public int? DcCasualtyId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 3)]
        public string IsIntendingToFileClaim { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public string HasClaimSettled { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public string SettlementStatusCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public string InjuryTypeCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public DateTime? InjuryDate { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string InsuranceCompanyName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public string PolicyNumber { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public string AttorneyName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public int[] CasualtyOtherMembersInvolved { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public int? ResponsiblePartyIndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public Address ThirdPartyAddress { get; set; }

    }
    #endregion
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class RepresentativeType : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public int? RepresentativeTypeAssociationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 1)]
        public string RepresentativeTypeCode { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CareTakerSchedule : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public int? EnrollmentScheduleInformationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 1)]
        public int IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public DateTime? FromDate { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public DateTime? EndDate { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public EnrollmentSchedule[] EnrollmentSchedules { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public string HasCaretakerSchedule { get; set; }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class EnrollmentSchedule : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public int? EnrollmentScheduleId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public int? EnrollmentScheduleInformationId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 2)]
        public int IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public bool? RegularMonday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public bool? RegularTuesday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public bool? RegularWednesday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public bool? RegularThursday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public bool? RegularFriday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public bool? RegularSaturday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public bool? RegularSunday { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public string ScheduleEntityName { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public string ScheduleTypeCode { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 12)]
        public string StartTime { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = false, Order = 13)]
        public string EndTime { get; set; }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CcoSelection : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int IndividualId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string SelectedCcoId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CcoDescription { get; set; }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class CommunityPartner : controlInfo
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int? AgencyId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int? AgencyEmployeeId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string OrganizationName { get; set; }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class SpecificIncomeDetails : controlInfo
    {
        [XmlElement(Order = 1)]
        public int? SpecificIncomeDetailId { get; set; }
        [XmlElement(Order = 2)]
        public int IndividualId { get; set; }
        [XmlElement(Order = 3)]
        public string EmployerName { get; set; }
        [XmlElement(Order = 4)]
        public string JobTitle { get; set; }
        [XmlElement(Order = 5)]
        public string IncomeCategoryCode { get; set; }
        [XmlElement(Order = 6)]
        public string IncomeTypeCode { get; set; }
        [XmlElement(Order = 7)]
        public DateTime? EmploymentStartDate { get; set; }
        [XmlElement(Order = 8)]
        public DateTime? FirstPayDate { get; set; }
        [XmlElement(Order = 9)]
        public decimal? GIBillDeductionAmount { get; set; }
        [XmlElement(Order = 10)]
        public decimal? CombatPayAmount { get; set; }
        [XmlElement(Order = 11)]
        public decimal? ActiveServiceAmount { get; set; }
        [XmlElement(Order = 12)]
        public decimal? CashMedicalSupportAmount { get; set; }
        [XmlElement(Order = 13)]
        public decimal? RoomAndBoardAmount { get; set; }
        [XmlElement(Order = 14)]
        public decimal? DisabilityTaxableAmount { get; set; }
        [XmlElement(Order = 15)]
        public decimal? AmountPaidToAttendant { get; set; }
        [XmlElement(Order = 16)]
        public int? CCPReceivedFrom { get; set; }
        [XmlElement(Order = 17)]
        public int? PaymentMadeTo { get; set; }
        [XmlElement(Order = 18)]
        public int? PaymentLegallyObligatedTo { get; set; }
        [XmlElement(Order = 19)]
        public string IsOnTemporaryLeave { get; set; }
        [XmlElement(Order = 20)]
        public string ThirdPartyTypeCode { get; set; }
        [XmlElement(Order = 21)]
        public string ChildSupportTypeCode { get; set; }
        [XmlElement(Order = 22)]
        public string PaymentMadeBy { get; set; }
        [XmlElement(Order = 23)]
        public string IsLegallyObligated { get; set; }
        [XmlElement(Order = 24)]
        public string ReimbursementTypeCode { get; set; }
        [XmlElement(Order = 25)]
        public int? ReceivingCareCaseMember { get; set; }
        [XmlElement(Order = 26)]
        public string ReceivingCareNonCaseMember { get; set; }
        [XmlElement(Order = 27)]
        public string IsProvidesCareQualified { get; set; }
        [XmlElement(Order = 28)]
        public string WIOAPaymentTypeCode { get; set; }
        [XmlElement(Order = 29)]
        public string JobCorpsPaymentTypeCode { get; set; }
        [XmlElement(Order = 30)]
        public string VocPaymentTypeCode { get; set; }
        [XmlElement(Order = 31)]
        public string StipendsSourceFunding { get; set; }
        [XmlElement(Order = 32)]
        public string IsEmployerSponsored { get; set; }
        [XmlElement(Order = 33)]
        public string IsEmployedRecuperating { get; set; }
        [XmlElement(Order = 34)]
        public string IsDisabilityPremiumPaid { get; set; }
        [XmlElement(Order = 35)]
        public string IsReimbursementBusinessEntity { get; set; }
        [XmlElement(Order = 36)]
        public string IsReimbursementMoney { get; set; }
        [XmlElement(Order = 37)]
        public string IsReimbursementCoverIntendedExpense { get; set; }
        [XmlElement(Order = 38)]
        public string IsReimbursementCoveredProgramBenefits { get; set; }
        [XmlElement(Order = 39)]
        public string IsRoyaltyTrade { get; set; }
        [XmlElement(Order = 40)]
        public string IsReceivingWorkPublicationPayment { get; set; }
        [XmlElement(Order = 41)]
        public string IsActivityMeetEmploymentCriteria { get; set; }
        [XmlElement(Order = 42)]
        public string IsReceivedAsMoney { get; set; }
        [XmlElement(Order = 43)]
        public string IsIndividualPrinicipal { get; set; }
        [XmlElement(Order = 44)]
        public string IsEmployedCertifiedChildCare { get; set; }
        [XmlElement(Order = 45)]
        public string IsAwayFromHome { get; set; }
        [XmlElement(Order = 46)]
        public string IsMedalOfHonor { get; set; }
        [XmlElement(Order = 47)]
        public string AttendingProgramTypeCode { get; set; }
        [XmlElement(Order = 48)]
        public string IsVista { get; set; }
        [XmlElement(Order = 49)]
        public string IsEducationalAward { get; set; }
        [XmlElement(Order = 50)]
        public string ShelterIncomeType { get; set; }
        [XmlElement(Order = 51)]
        public string LeaveReasonCode { get; set; }
        [XmlElement(Order = 52)]
        public DateTime? ExpectedDateofReturn { get; set; }
        [XmlElement(Order = 53)]
        public DateTime? DisabilityLastDateWorked { get; set; }
        [XmlElement(Order = 54)]
        public DateTime? VistaStartDate { get; set; }
        [XmlElement(Order = 55)]
        public DateTime? LastPayDate { get; set; }
        [XmlElement(Order = 56)]
        public string EndReasonCode { get; set; }
        [XmlElement(Order = 57)]
        public DateTime? EndDate { get; set; }
        [XmlElement(Order = 58)]
        public DateTime? DateOfChange { get; set; }
        [XmlElement(Order = 59)]
        public IncomePayDetail IncomePayDetail { get; set; }
        [XmlElement(Order = 60)]
        public decimal? UsDaTotalAmount { get; set; }
        [XmlElement(Order = 61)]
        public decimal? ChildCareAmount { get; set; }
        [XmlElement(Order = 62)]
        public string DoesIndividualActivelyParticipate { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 63)]
        public DateTime? TemporaryLeaveDate { get; set; }
        [XmlElement(Order = 64)]
        public string IsIndividualOwnershipInterest { get; set; }

        [XmlElement(Order = 65)]
        public string IsIndividualActivelyWorking { get; set; }

        [XmlElement(Order = 66)]
        public int? ChildToWhichPaymentSupport { get; set; }

        [XmlElement(IsNullable = true, Order = 67)]
        public string HasAnyBenefitDueToDisability { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 68)]
        public string IsTemporarilyOnLeaveDueToSickChild { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 69)]
        public int? ChildIndividualId { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskPrimaryAttribute : object, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElementAttribute(Order = 0)]
        public string PrimaryAttrAdditionalValue1 { get; set; }

        [XmlElementAttribute(Order = 1)]
        public string PrimaryAttrAdditionalValue2 { get; set; }

        [XmlElementAttribute(Order = 2)]
        public string PrimaryAttrAdditionalValue3 { get; set; }

        [XmlElementAttribute(Order = 3)]
        public string PrimaryAttrAdditionalValue4 { get; set; }

        [XmlElementAttribute(Order = 4)]
        public string PrimaryAttributeCode { get; set; }

        [XmlElementAttribute(Order = 5)]
        public string PrimaryAttributeValue { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class AnnualIncomeDetails : controlInfo
    {
        [XmlElementAttribute(Order = 0)]

        public int IndividualId { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 1)]

        public int? ApplicationNumber { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 2)]


        public int? CaseNumber { get; set; }
        [XmlElementAttribute(Order = 3)]

        public int CoverageYear { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 4)]

        public decimal? ProjectedEarnedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 5)]

        public decimal? ProjectedAnnualSsbIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 6)]

        public decimal? ProjectedUnearnedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 7)]

        public decimal? ProjectedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 8)]

        public decimal? ProjectedAnnualDeductionAmount { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 9)]

        public string IsEarnedIncomeDifferent { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 10)]

        public string IsSsbIncomeDifferent { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 11)]

        public string IsUnearnedIncomeDifferent { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 12)]

        public string IsDeductionDifferent { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 13)]

        public decimal? ReportedEarnedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 14)]

        public decimal? ReportedAnnualSsbIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 15)]

        public decimal? ReportedUnearnedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 16)]

        public decimal? ReportedAnnualDeductionAmount { get; set; }

        [XmlElementAttribute(IsNullable = true, Order = 17)]
        public decimal? ReportedAnnualIncome { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 18)]

        public decimal? TotalReportedAnnualAmount { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 19)]

        public decimal? GrossProjectedIncomeAmount { get; set; }
        [XmlElementAttribute(IsNullable = true, Order = 20)]

        public decimal? GrossProjectedDeductionAmount { get; set; }

    }
    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class TaskTypeComments : controlInfo
    {
        [XmlElementAttribute(Order = 1)]
        public string TaskType { get; set; }
        [XmlElementAttribute(Order = 2)]
        public string TaskComments { get; set; }
    }


    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class AdditionalInformation : controlInfo
    {

        /// <remarks/>
        [XmlElementAttribute(IsNullable = true, Order = 1)]
        public string AdditionalInfoTypeCode { get; set; }

        /// <remarks/>
        [XmlElementAttribute(IsNullable = true, Order = 2)]
        public string AdditionalInfoTypeValue { get; set; }

        /// <remarks/>
        [XmlElementAttribute(IsNullable = true, Order = 3)]
        public string AdditionalInfoComments { get; set; }
    }

    [GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://hbe.ky.gov/xsd/INT_PUSH_AR_APPL_REG_V1.0.xsd")]
    public class ScreenCategoryMapping : controlInfo
    {
        #region Public Properties

        /// <summary>
        /// Property to check if Household Member Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public bool IsHouseholdMemberInformationUpdated { get; set; }

        /// <summary>
        /// Property to check if Additional Demographic Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public bool IsAdditionalDemographicInformationUpdated { get; set; }

        /// <summary>
        /// Property to check if Individual Demographics Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public bool IsIndividualDemographicInformationUpdated { get; set; }

        /// <summary>
        /// Property to check if DetailsOfYouAndYourHousehold is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public bool IsDetailsOfYouAndYourHouseholdUpdated { get; set; }

        /// <summary>
        /// Property to check if ICareTakerUnableToProvideCare is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public bool IsCareTakerUnableToProvideCareUpdated { get; set; }

        /// <summary>
        /// Property to check if American Indian, Alaskan Native Information Care is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public bool IsAianUpdated { get; set; }

        /// <summary>
        /// Property to check if Deceased Member Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 7)]
        public bool IsDeceasedMemberInformationUpdated { get; set; }

        /// <summary>
        /// Property to check if HouseHold Disability Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 8)]
        public bool IsHouseHoldDisabilityInformationUpdated { get; set; }

        /// <summary>
        /// Property to check if Unable To Work Information is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 9)]
        public bool IsUnableToWorkUpdated { get; set; }

        /// <summary>
        /// Property to check if Annual Income Summary is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 10)]
        public bool IsAnnualIncomeSummaryUpdated { get; set; }

        /// <summary>
        /// Property to check if Safety Questions is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 11)]
        public bool IsSafetyQuestionsUpdated { get; set; }

        /// <summary>
        /// Property to check if Household Situation is Updated or not
        /// </summary>
        [XmlElementAttribute(Order = 12)]
        public bool IsHouseholdSituationUpdated { get; set; }

        #endregion
    }

}

