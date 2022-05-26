using System;
using System.Collections.Generic;
using System.Text;

namespace INN8_Api_Models.Constants
{
    public class ApplicationConstants
    {

        public ApplicationConstants()
        {

        }
        public const decimal Hundred = 100m;
        public const string JSECode = "JSFC";
        public const string ISINCode = "ISIN";
        public const string SAR2Code = "SAR2";

        public const string purposeOfInvestmentCode = "1POI";

        public const string routePageAccountValuation = "/accountValuation";

        public const string Amount = "Amount";
        public const string Unit = "Unit";
        public const string Percentage = "Percentage";

        public const string validationModeSuccess = "BRA-10016 - Validation mode detected. No errors found";

        // Transaction History Status
        public const string pricedDate = "Settled";
        public const string effectiveDate = "Inflight";
        public const string processedDate = "Processed";
        public const string InitialAdviceFee = "Initial advice fee";
        public const string InitialAdviceFeeVAT = "Initial advice fee VAT";
        public const string WebApplicationCashDebit = "Web Application Cash Debit";
        public const string ApplicationDepositandInvestmentDebitCash = "Application (Deposit and Investment) Debit Cash";
        public const string RegularPaymentDebitCash = "Regular Payment Debit Cash";
        public const string VAT_InitAdv = "VAT - Init Adv";
        public const string InitAdviceFee = "Init Advice Fee";
        public static List<string> transactionHistoryCodeForDuplicateFee = new List<string>()
    {
      ApplicationDepositandInvestmentDebitCash,
      WebApplicationCashDebit,
      RegularPaymentDebitCash
    };

        // Document upload
        public const string docUploadMalwareFound = "The group or resource is not in the correct state";
        public const string docUploadMalwareService = "DocumentUpload AMSI Malware Check";
        public const string docUploadFailed = "Error occured while uploading document - ";
        public const string docUploadMalwareScannerServiceName = "INN8MalwareScanner";

        // Income distribution
        public const string incomeDistributionDistributionMethodCode = "REIN";
        public const string incomeDistributionDistributionMethodCodeType = "IDCH";
        public const string incomeDistributionJourneyManageAssets = "ManageAssets";
        public const string incomeDistributionJourneyTopUp = "TopUp";

        // Time travel cache identifiers
        public const string enableTimeTravel = "enableTimeTravel";
        public const string diffInSec = "diffInSec";

        // RelationshipCodes & tags
        public const string relationshipTypeGeneralPOA = "GPOA";
        public const string relationshipTypeGuardianCode = "GRDN";
        public const string relationshipTypeParentCode = "1PRT";
        public const string relationshipJourneyNameTag = "journeyName=";
        public const string relationshipDependentTypeTag = "1DEP=";

        // Fund status codes
        public const string fundCLOSCode = "CLOS";
        public const string fundCLNWCode = "CLNW";

        public const string fundDEFRCode = "DEFR";
        public const string fundSUSPCode = "SUSP";
        public const string fundMGFRCode = "MGFR";

        public const string fundCashFullName = "Cash PCA";

        // Transfer Event codes
        public const string transactionTypeFullTransferOut = "FTRP"; // Transf Out Full -> Transfer Out Full
        public const string transactionTypePartialTransferOut = "PTFO"; // Transf Out Prtl -> Transfer Out Partial
        public const string transactionTypeFullReregistrationOut = "FROT"; // Re-reg Out Full -> Full Re-registration Out
        public const string transactionTypePartialReregistrationOut = "RROT"; // Re-reg Out Prtl -> Re-registration Out

        // Transfer Event statuses
        public const string transferStatusCancelled = "CANC";
        public const string transferStatusRejected = "REJC";
        public const string transferStatusReversed = "REVS";

        // Model Portfolio fund type
        public const string fundMPAssetType = "MPAsset";

        public const string mpStatuses = "PSTA";
        public const string mpStatusOpen = "OPEN";
        public const string mpModeEdit = "edit";
        public const string mpModeClone = "clone";


        public const string fundCashType = "Cash";
        public const string fundAssetsType = "Assets";
        public const string fundMorningstarType = "Morningstar";
        public const string fundModelPortfolioType = "ModelPortfolio";

        // Model Portfolio Creation Step01
        public const string ric = "RCNT";
        public const string firm = "ADNT";
        public const string dfmOngoingFee = "DFM Ongoing Fee";
        public const string ricOngoingFee = "RIC Ongoing Fee";
        public const string ricOngoingFeeExpenseName = "RIC On-going";
        public const string vatChargeDfm = "VAT Charge-DFM";
        public const string vatChargeRic = "VAT Charge-RIC";
        public const string vatAmount = "VAT - 15%";

        // Email validation
        public const string emailInUse = "This email address is already in use";
        public const string emailNoRecordsFound = "No records were found with your given criteria";
        public const string emailNoErrorsFound = "No errors found";
        public const string emailNotValid = "does not appear to be a valid email address";
        public const string emailInvalid = "Invalid email";

        // Save account expense
        public const string expenseLineChargeBasisCode = "CLCA";
        public const string expenseLineChargeBasisCodeType = "ECCB";

        // Adviser and DFM outletTypeCode
        public const string adviserOutletCode = "ADVS";
        public const string DFMOutletCode = "1DFM";

        // Model portfolio generic
        public const string dfmType = "DFM";
        public const string ricType = "RIC";
        public const string ricRelationshipTypeCode = "TCOM";

        // Model portfolio status codes
        public const string statusTRIACode = "TRIA";
        public const string statusCLONCode = "CLON";
        public const string statusOPENCode = "OPEN";
        public const string statusCLOSCode = "CLOS";

        public const string statusDraftName = "Draft";
        public const string statusClosedName = "Closed";
        public const string statusCappedName = "Capped for new business";
        public const string statusActiveName = "Active";
        public const string statusPendingName = "Pending launch";
        public const string statusActivePendingName = "Active pending launch";

        // Model portfolio document recreation
        public const string clientsIncluded = "Clients included in {purpose}";
        public const string clientsExcluded = "Clients excluded in {purpose}";

        // Model portfolio summary
        public const string ricCode = "1RIC";

        // Client Identifiers
        public const string clientTypePers = "PERS";

        public const string clientEmailIdentifier = "EMAL";
        public const string clientEmailICodeTypedentifier = "ADDR";
        public const string clientResidentialIdentifier = "RESI";

        public const string clientADDRIdentifier = clientEmailICodeTypedentifier;
        public const string clientCOMPIdentifier = "COMP";
        public const string clientTRSTIdentifier = "TRST";
        public const string clientCOMPIdentifierReport = "COMPANY";
        public const string clientTRSTIdentifierReport = "TRUST";
        public const string clientCORPIdentifier = "CORP";
        public const string clientEmailIdentifierType = "LDM";
        public const string clientForgotUsernameTemplateCode = "NAPR";

        // Correspondence

        public const string templateCodeAdviserFeesFAAF = "FAAF";
        public const string templateCodeAdviserFeesFAFF = "FAFF";
        public const string templateCodeCapitalGainsTaxRealiseGainsOrLoss = "RGL1";
        public const string templateCodeCapitalGainsTaxContributionThreshold = "NAAT";
        public const int capitalGainsTaxCodeGain = 4250;
        public const int capitalGainsTaxCodeLoss = 4251;
        public const string fileGenerationErrorMessage = "There is no tax certificate available for the date range selected";
        public const string productNameError = "Products name is not set.";

        // Client is a company or trust so Address is a BUSN type
        public const string clientBUSNIdentifier = "BUSN";
        public const string clientPOSTIdentifier = "POST";

        // Client is an individual, so address is RESI type
        public const string clientRESIIdentifier = "RESI";

        // Withholding Tax Constants
        public const string withholdingTaxCodeType = "DWTT";
        public const string dividendExemptTaxReasonsCodeType = "DWER";
        public const string interestExemptTaxReasonsCodeType = "IWER";
        public const string reducedRateReasonCode = "RE02";
        public const string reducedRateReasonCodeType = "DTRR";
        public const string companyRegReferenceCode = "SARN";

        // FATCA/CRS identifiers
        public const string saCitizenCode = "1SAC";
        public const string usaCitizenCode = "1USC";
        public const string registeredSaTaxCode = "1RTP";
        public const string registeredUsaTaxCode = "1RTU";
        public const string registeredOtherTaxCode = "1RTM";
        public const string fatcaCrsCertStatusCode = "1FCR";

        public const string saCitizenQuestion = "saCitizen";
        public const string usaCitizenQuestion = "usaCitizen";
        public const string registeredSaTaxQuestion = "registeredSaTax";
        public const string registeredUsaTaxQuestion = "registeredUsaTax";
        public const string registeredOtherTaxQuestion = "registeredOtherTax";

        public const string fatcaCrsAnswerYes = "Y";
        public const string clientWorkflowFatcaCrsTagYes = "Y";
        public const string clientWorkflowFatcaCrsTagNo = "N";

        public const string INCNIdentifier = "INCN";
        public const string NFCRIdentifier = "NFCR";
        public const string INTRIdentifier = "INTR";
        public const string CLNRIdentifier = "CLNR";
        public const string IYCNIdentifier = "IYCN";
        public const string INCYIdentifier = "INCY";
        public const string FCRIdentifier = "1FCR";

        // Client details identifiers
        public const string CLTYIdentifier = "CLTY"; // _request.client.clientDetails.typeCode

        public const string SAIDIdentifier = "SAID"; // ClientExternalReferences SAID
        public const string PSPTIdentifier = "PSPT"; // ClientExternalReferences PSPT
        public const string trustTypeIdentifier = "SATO"; // ClientExternalReferences SATO
        public const string TITLIdentifier = "TITL"; // _request.client.clientDetails.title
        public const string maritalIdentifier = "MARI"; // _request.client.clientDetails.maritalStatus
        public const string nationalityIdentifier = "CNAT"; // _request.client.clientDetails.Nationality

        // /Tax residency is not same as Nationality so Code is Secondary
        public const string residentialCountryTypeCode = "TTAS";
        public const string residentialCountryTypeCodePrimary = "TTAP";

        public const string residentialCountryTypeCodeType = "TTAC";

        public const string residencyStatusCode = "CERT";
        public const string residencyStatusCodeType = "TRSD";

        public const string evidenceCode = "CRES";
        public const string evidenceCodeType = "SCEV";

        public const string taxIdentifierTypeCode = "TIIT";
        public const string taxIdentifierTypeCodeType = "TINT";

        public const string reportingRegimeCode_FATC = "FATC";
        public const string reportingRegimeCode_CRS = "CRS";
        public const string reportingRegimeCodeType = "TXRG";

        public const string classificationCodeIndividual = "SFID";
        public const string classificationCodeEntity = "SFEN";
        public const string classificationCodeType = "TATS";

        public const string bankTypeCodeCode = "BANK";
        public const string bankTypeCodeCodeType = bankTypeCodeCode;

        public const string beneficiaryTypePERS = "PERS";
        public const string beneficiaryTypeCOMP = "COMP";
        public const string beneficiaryTypeTRST = "TRST";
        public const string beneficiaryExtRefSAID = "SAID";
        public const string beneficiaryExtRefPSPT = "PSPT";
        public const string beneficiaryExtRefSATO = "SATO";
        public const string beneficiaryExtRefSARN = "SARN";

        // Regulation 28
        public const string grandfatheredCode = "SAGR";
        public const string compliantLabel = "Compliant";
        public const string nonCompliantLabel = "Non compliant";
        public const string grandfatheredLabel = "Grandfathered";
        public const string NO = "NO";
        public const string YN = "YN";

        // Company Reg Number Validation
        public const string investorTypeCompanycodeType = "INTC";
        public const string MES148 = "An entity with the same registration number already exists.";

        // Model PortFolio duplication validation
        public const string MES068 = "A model portfolio with the same name already exists";

        // ID Number duplication validation
        public const string MES159 = "A client with the same ID number / passport number already exists. Please search for the original.";
        public const string MES166 = "[TXT_E_1]";

        // Adviser fee maintenance
        public const string MES176 = "[TXT_E_2]";

        // ClientContextType
        public const string CNTXCode = "CNTX";

        // Adviser values
        public const string adviserTypeValue = "Adviser";

        public const string adviserRelationshipTypeCode = "INIT";

        // Client gender identifiers
        public const string clientMaleIdentifier = "MALE";

        public const string clientGenderIdentifier = "SEX";

        public const string occupationTypeCode = "1OCC";

        // Client titles

        public const string clientTitleOther = "OTHER";

        // Workflow Identifiers
        public const string documentWorkflowProcessCode = "documentUpload";

        public const string newBusinessWorkflowProcessCode = "newBusinessGIP";
        public const string clientWorkflowProcessCode = "maintainClient";
        public const string retirementWithdrawalWorkflowProcessCode = "retireProcess";

        public const string bankValidationWorkflowJourneyType = "journeyType";
        public const string bankValidationWorkflowClientMaintenance = "Client Maintenance";
        public const string bankValidationWorkflowBankAccountNumber = "bankAccountNumber_bv";

        public const string bankValidationProcessModelCode = "manBankVal";
        public const string workflowStartEventCode = "webStart";

        public const string paymentMethodCodeDirectDebit = "DD";
        public const string paymentMethodCodeDirectCredit = "DC";
        public const string paymentMethodCodeType = "LSPT";

        // GenericBusinessData -> GetNewBusinessProducts()
        public const string productDetailStatusCode = "OPNC";

        public const string productDetailClientRelationshipCode = "OWNR";
        public const string productDetailClientTypeRuleCode = "NATU";

        // Used to find the regular contribution frequencies
        public const string productRegularContributionMethodIdentifier = "UT Payer Control";

        // Used to find the regular withdrawal frequencies
        public const string productRegularWithdrawalMethodIdentifier = "UT Recipient Control";

        // SearchClient reference & referenceCode
        public const string searchReferenceY = "Y";

        public const string searchReferenceINSTCode = "INST";

        // TFSA default values for (Prospect)
        public static decimal tfsaAnnualLimit = decimal.Parse("33,000", System.Globalization.CultureInfo.InvariantCulture);

        public static decimal tfsaLifetimeLimit = decimal.Parse("500,000", System.Globalization.CultureInfo.InvariantCulture);

        // VAT fee expenseTypeCode Identifiers
        public const string vatFeeVATCExpenseTypeCode = "VATC";

        public const string vatFeeZUVCExpenseTypeCode = "ZUVC";
        public const string vatFeeINCMExpenseTypeCode = "INCM";
        public const string vatFeeIANExpenseTypeCode = "IANE";
        public const string vatFeeZVTDExpenseTypeCode = "ZVTD";
        public const string vatFeeZVTRExpenseTypeCode = "ZVTR";

        // expenseTypeCode Identifiers
        public const string noVatDFMExpenseTypeCode = "OCDM";
        public const string noVatRICExpenseTypeCode = "RICO";

        // Expense line descriptions to distinguish between Ongoing adviser fees, Initial adviser fee: Lump sum and Initial adviser fee: Regular Contribution
        public const string expenseLineOngoingAdviserFees = "Adv Ongoing Fee generates Adv Ongoing Fee for Adv Ongoing Fee as $ Amount or % of Daily Ave Bal";

        public const string tfsaExpenseLineInitialLumpSumAdviserFees = ", Init Advice Fee on NoWrap Cash Lump Sum Inv as $ Amount Or % of Trans Value"; // The space is intentional
        public const string expenseLineInitialLumpSumAdviserFees = ", Init Advice Fee on Lump Sum Inv as $ Amount Or % of Trans Value";
        public const string expenseLineInitialLumpSumAdviserFeesWebApplication = "Init Advice Fee on Web Application as $ Amount Or % of Trans Value";
        public const string tfsaxpenseLineInitialRegularContributionAdviserFees = ", Init Advice Fee on NoWrap Cash Reg Investment as $ Amount Or % of Trans Value";
        public const string expenseLineInitialRegularContributionAdviserFees = ", Init Advice Fee on Reg Investment as $ Amount Or % of Trans Value";

        public static IDictionary<string, string> INN8Statuses = new Dictionary<string, string>()
        {
                { "Trail", "Draft" },
                { "Active before lunch date", "Pending Launch" },
                { "Active on launch date", "Active" },
                { "Close for New Business", "Capped for New Business" },
                { "Closed", "Closed" }
        };

        //Codes for getFund fields
        public const string reg28Code = "SAR2";
        public const string morninstarCode = "MGFR";
        public const string jseCode = "JSFC";
        public const string isinCode = "ISIN";

        // Life Assured
        public const string lifeCode = "LIFE";

        // Account Beneficiary
        public const string codeCategoryBeneficiaryDEAT = "DEAT";
        public const string codeTypeCategoryBeneficiary = "BCAT";
        public const string codeForTypeBeneficiaryTPIN = "TPIN";
        public const string codeTypeForTypeBeneficiary = "BTYP";

        // Transfer Type
        public const string transferTypeCash = "Cash";
        public const string transferTypeUnits = "Units";
        public const string transferTypeUnitsWorkflow = "Unit";

        #region OngoingFeeInformation values

        /// <summary>
        /// OngoingFeeInformation -> Find in _getAdvisorResponse -> expenseOverride where name is ongoingFeeName and expenseType -> code is ongoingFeeVATCExpenseTypeCode or ongoingFeeZUVCExpenseTypeCode
        /// </summary>
        public const string ongoingFeeName = "Adv Ongoing Fee";

        public const string ongoingTransactionTypeCode = "IFAT";

        #endregion OngoingFeeInformation values

        #region LumpSumInformation values

        /// <summary>
        /// LumpSumInformation -> Find in _getAdvisorResponse -> expenseOverride where transaction type  is lumpSumTransactionTypeCode and expenseType -> code is ongoingFeeVATCExpenseTypeCode or ongoingFeeZUVCExpenseTypeCode
        /// </summary>
        public const string lumpSumTransactionTypeCode = "LSUM";
        public const string cashTransferTransactionTypeCodeLA = "RTI";
        public const string cashTransferTransactionTypeCodeNotLA = "PLTF";
        public const string adjustmentInvestmentTypeCode = "ADJM";
        public const string webApplicationLumpSumTransactionTypeCode = "APPL";


        #endregion LumpSumInformation values

        #region RegularContributionInformation values

        /// <summary>
        /// RegularContributionInformation -> Find in _getAdvisorResponse -> expenseOverride where transaction type  is regularContributionTransactionTypeCode and expenseType -> code is ongoingFeeVATCExpenseTypeCode or ongoingFeeZUVCExpenseTypeCode
        /// </summary>
        public const string regularContributionTransactionTypeCode = "RCON";
        public const string regularContributionSuspAccCode = "SUSP";
        public const string regularContributionActiveAccCode = "REG";

        #endregion RegularContributionInformation values

        #region New Business / Quick Quote Constants

        /// <summary>
        /// A class containing the various product short names.
        /// Note only ever add product short names here as there is logic that dynamically uses the properties within this class.
        /// </summary>
        public class ProductTypes
        {
            public const string retirementAnnuity = "Ret Annuity";
            public const string taxFreeSavingsAccount = "Tax Free Sav";
            public const string providentPreservation = "Provident Pres";
            public const string pensionPreservation = "Pension Pres";
            public const string livingAnnuity = "Living Annuity";
            public const string investmentAccount = "Invest Account";
            public const string endowment = "Endowment";
            public const string sinkingFund = "Sinking Fund";
            public const string wrapCash = "Wrap Cash";
            public const string offShoreIA = "Offshore IA";
        }

        public Dictionary<string, string> OldProductShortName()
        {
            Dictionary<string, string> oldProductShortNames = new Dictionary<string, string>();
            oldProductShortNames.Add("Ret Annuity", "Ret Annuity");
            oldProductShortNames.Add("Tax Free Sav", "Tax Free Sav");
            oldProductShortNames.Add("Provident Pres", "Prov Pres");
            oldProductShortNames.Add("Pension Pres", "Pen Pres");
            oldProductShortNames.Add("Living Annuity", "Living Annuity");
            oldProductShortNames.Add("Invest Account", "Invest Acc");
            oldProductShortNames.Add("Endowment", "Life Endowment");
            oldProductShortNames.Add("Sinking Fund", "Sinking Fund");
            return oldProductShortNames;
        }

        public Dictionary<int, string> ProductShortNamesKeyValue()
        {
            Dictionary<int, string> productShortNamesKeyValue = new Dictionary<int, string>();
            productShortNamesKeyValue.Add(1, "Invest Account");
            productShortNamesKeyValue.Add(2, "Tax Free Sav");
            productShortNamesKeyValue.Add(3, "Living Annuity");
            productShortNamesKeyValue.Add(4, "Ret Annuity");
            productShortNamesKeyValue.Add(5, "Provident Pres");
            productShortNamesKeyValue.Add(6, "Pension Pres");
            productShortNamesKeyValue.Add(7, "Endowment");
            productShortNamesKeyValue.Add(8, "Sinking Fund");
            return productShortNamesKeyValue;
        }

        public static Dictionary<string, string> ProductAcronymKeyValue = new Dictionary<string, string>
    {
      {"IA", ProductTypes.investmentAccount},
      {"TX", ProductTypes.taxFreeSavingsAccount},
      {"LA", ProductTypes.livingAnnuity},
      {"ENS", ProductTypes.sinkingFund},
      {"ENL", ProductTypes.endowment},
      {"PE", ProductTypes.pensionPreservation},
      {"PR", ProductTypes.providentPreservation},
      {"RA", ProductTypes.retirementAnnuity}
    };

        public static Dictionary<string, string> ProductNameReg28()
        {
            Dictionary<string, string> productShortNames = new Dictionary<string, string>()
      {
        {"Ret Annuity", string.Empty },
        {"Provident Pres", string.Empty },
        {"Pension Pres", string.Empty },
      };
            return productShortNames;
        }

        public class ImagoProductCodes
        {
            public const string retirementAnnuity = "RETANN";
            public const string taxFreeSavingsAccount = "TFSA";
            public const string providentPreservation = "PROVPRES";
            public const string pensionPreservation = "PENPREV";
            public const string livingAnnuity = "LIVANN";
            public const string investmentAccount = "GIA";
            public const string endowment = "ENDOW";
            public const string sinkingFund = "SINK";
        }
        public class ProductCodes
        {
            public const string pensionPresFund = "1PPE";
            public const string providentPresFund = "1PPR";
            public const string retirementAnnuity = "RANF";
            public const string livingAnnuity = "1LVA";
        }

        public class CountryCodes
        {
            public const string southAfrica = "ZA";
            public const string unitedStates = "US";
        }

        public class ValueCode
        {
            public const string codeTypeVALU = "VALU";
            public const string codeRetirementAge = "RETA";
            public const string codePreRetirementWithdrawalMaximum = "PRWA";
            public const string codeLivingAnnuityFullWithdrawalMinimum = "MCCA";
        }

        public const string imagoDocumentType = "ILLU";

        public class ImagoAdviserCharges
        {
            public const string ongoingAdviserCharge = "Ongoing Adviser Charge";
            public const string initialAdviserChargeSingleContribution = "Initial Adviser Charge Single Contribution";
            public const string initialAdviserChargeRegularContribution = "Initial Adviser Charge Regular Contribution";
            public const string administrationCharge = "Administration Charge";
            public const string discretionaryInvestmentManagerCharge = "Discretionary Investment Manager Charge";
            public const string researchInvestmentManagerCharge = "Research Investment Manager Charge";
        }

        public class BusinessApplicationTypes
        {
            public const string newBusiness = "New Business";
            public const string quickQuote = "Quick Quote";
            public const string topUp = "Top Up";
            public const string withdrawal = "withProc";
        }

        public class ApplicationStepTypes
        {
            public class SelectProduct
            {
                public const string selectProduct = "Select product";
                public const int selectProductStepNumber = 0;
            }

            public class ContributionType
            {
                public const string contributionType = "Contribution type";
                public const int contributionTypeStepNumber = 1;
            }

            public class ContributionsAndFees
            {
                public const string contributionsAndFees = "Contributions and fees";
                public const int contributionsAndFeesStepNumber = 2;
            }

            public class AssetAllocation
            {
                public const string assetAllocation = "Asset allocation";
                public const int assetAllocationStepNumber = 3;
            }

            public class ProductFeatures
            {
                public const string productFeatures = "Product features";
                public const int productFeaturesStepNumber = 4;
            }

            public class PaymentOptions
            {
                public const string paymentOptions = "Payment options";
                public const int paymentOptionsStepNumber = 5;
            }

            public class ApplicationSummary
            {
                public const string applicationSummary = "Application summary";
                public const int applicationSummaryStepNumber = 6;
            }

            public class Declaration
            {
                public const string declaration = "Declaration";
                public const int declarationStepNumber = 7;
            }

            public class Confirmation
            {
                public const string confirmation = "Confirmation";
                public const int confirmationStepNumber = 8;
            }

            public static IDictionary<int, string> applicationStepTypesList = new Dictionary<int, string>()
            {
                    { SelectProduct.selectProductStepNumber, SelectProduct.selectProduct },
                    { ContributionType.contributionTypeStepNumber, ContributionType.contributionType },
                    { ContributionsAndFees.contributionsAndFeesStepNumber, ContributionsAndFees.contributionsAndFees },
                    { AssetAllocation.assetAllocationStepNumber, AssetAllocation.assetAllocation },
                    { ProductFeatures.productFeaturesStepNumber, ProductFeatures.productFeatures },
                    { PaymentOptions.paymentOptionsStepNumber, PaymentOptions.paymentOptions },
                    { ApplicationSummary.applicationSummaryStepNumber, ApplicationSummary.applicationSummary },
                    { Declaration.declarationStepNumber, Declaration.declaration },
                    { Confirmation.confirmationStepNumber, Confirmation.confirmation },
            };
        }

        public class ExpenseLineConstants
        {
            public const string regApplication = "Reg Appl";
            public const string lumpsum = "Lump Sum";
            public const string cashTransferLA = "LA Transfer In";
            public const string cashTransferNotLA = "Plan Trnsfer In";
            public const string webApplication = "Web Application";
            public const string adviserOngoingFee = "Adv Ongoing Fee";
            public const string initialAdviceFee = "Init Advice Fee";
            public const string daop = "DAOP";
            public const string useWrapCash = "Use Wrap Cash";
            public const string IAFNoEffect = "IAF No Effect";
        }

        #endregion New Business / Quick Quote Constants

        #region Worksheet Information

        /// <summary>
        /// GetWorkflowResponse
        /// </summary>
        public const string workflowResponseWorksheetCode = "WEB1";
        public const string workflowResponseNewBusiness = "New Business Process GIP";
        public const string workflowResponseWithdrawalProcess = "Withdrawal Process";

        /// <summary>
        /// <summary>
        /// GetWorkflowRequirementResponse
        /// </summary>
        public const string workflowRequirementResponseWorksheetCode = "WEB2";
        public const string workflowDDWorksheetCode = "DDT01";
        public const string worksheetTypeEVNT = "EVNT";
        public const string worksheetFilterTypeACTN = "ACTN";

        #endregion Worksheet Information

        #region Account Activity

        /// <summary>
        /// From GetAccountTransactionListResponseType -> transEvtDetail
        /// </summary>
        public const string transEvtWITHTransTypeCode = "WITH";
        public const string transEvtWTHRTransTypeCode = "WTHR";
        public const string transEvtSWDLTransTypeCode = "SWDL";
        public const string transEvtDDDWTransTypeCode = "DDDW";
        public const string transEvtAPPLTransTypeCode = "APPL";
        public const string transEvtNORMTransStatusCode = "NORM";
        public const string transEvtPENDTransStatusCode = "PEND";
        public const string transEvtAFPATransStatusCode = "AFPA";
        public const string transEvtRPPMTransStatusCode = "RPPM";
        public const string transEvtTRSTTypeCode = "TRST";
        public const string genericVariableMAWDcode = "MAWD";
        public const string accountACTVCode = "ACTV";
        public const string accountPENDCode = "PEND";
        public const string clientOnboardedStatusActive = "ACTIVE";
        public const string clientOnboardedStatusPending = "PENDING";
        public const string clientOnboardedStatusInactive = "INACTIVE";
        public const string transPAYE_Tax = "PAYE Tax";
        public const string transITA88TaxDeduction = "ITA88 Tax Deduction (Transaction)";
        public const string fundLevelResultType = "INVESTMENT_TRANSACTION_DETAIL";

        // Fee Transaction Event Codes
        public const string transEvt_UnitLinkReduc = "ULRD";
        public const string transEvt_InitialCommiss = "INIT";
        public const string transEvt_TrailCommiss = "TRCO";
        public const string transEvt_Clawback = "CLBK";
        public const string transEvt_CanlStampDuty = "STDC";
        public const string transEvt_TrailingComm = "TCOM";
        public const string transEvt_FeesCharges = "FC";
        public const string transEvt_FCCancel = "UC";
        public const string transEvt_PlatformFee = "MFEE";
        public const string transEvt_PerDefEntFee = "PDEF";
        public const string transEvt_StampDuty = "STMP";
        public const string transEvt_InitialCharge = "INCH";
        public const string transEvt_Commission = "COMM";
        public const string transEvt_InsurancePrm = "INSP";
        public const string transEvt_InsPrem = "PREM";
        public const string transEvt_AClawback = "CLBA";
        public const string transEvt_UWIssueFee = "UWFE";
        public const string transEvt_AdminFee = "ADMI";
        public const string transEvt_KiwiSaverFee = "KFEE";
        public const string transEvt_CommonFundFee = "CFEE";
        public const string transEvt_OptRiderFee = "ORFE";
        public const string transEvt_InitialComm = "INIC";
        public const string transEvt_DripFeedFee = "DFFE";
        public const string transEvt_DIMOngoingFee = "INMF";
        public const string transEvt_AdmnFeeCash = "ADMF";
        public const string transEvt_AdviserFee = "ACCG";
        public const string transEvt_AdvOngoingFee = "TRAL";
        public const string transEvt_RICOngoingFee = "MBLE";
        public const string transEvt_FamGrpMPChrg = "FGMP";
        public const string transEvt_AccountFee = "ACFE";
        public const string transEvt_IntialAdvFee = "IADF";
        public const string transEvt_CommAdjustment = "COAD";
        public const string transEvt_LSExitFee = "EFEE";
        public const string transEvt_ITA88TaxDed = "WI8";
        public const string transEvt_CFFRebate = "CFER";
        public const string transEvt_IT88Tax = "IT88";
        public const string transEvt_OrphanedFee = "SAOR";
        public const string transEvt_IncGteeCharge = "IGCH";
        public const string transEvt_CapGteeCharge = "CGCH";
        public const string transEvt_AnnuityFee = "AHDF";
        public const string transEvt_SingUFPLSFee = "AHSU";
        public const string transEvt_RegUFPLSFee = "AHRU";
        public const string transEvt_AdminFeeDB = "ADD";
        public const string transEvt_TaxLiability = "TXLB";
        public const string transEvtWithdrawalTransTypeCodeType = "TACC";
        #endregion Account Activity

        #region Asset management details

        public class AssetManagement
        {
            public const string profileFunctionIdentifierCodeDFIV = "DFIV";
            public const string cashIdentifier = "CASH";
        }

        #endregion Asset management details

        #region Client application constants

        public const string clientApplicationIdPrimary = "C01";
        public const string clientApplicationIdSecondary = "C02";
        public const string clientApplicationIdTertiary = "C03";
        public const string clientApplicationId = clientApplicationIdPrimary;
        public const string taxDirectiveCode = "DIRC";
        public const string taxDirectiveCodeType = "TAXD";
        public const string payAsYouEarnTaxCode = "PAYE";

        // Special Tax codes
        public const string specialTaxDefaultCode = "PAYE";
        public const string specialTaxCodeType = "TAXD";
        public const string specialTaxLowerRateCode = "DIRC";
        public const string specialTaxHigherRateCode = "PEOR";
        public const string specialTaxLowerRateCodeWeb = "Lower tax rate";
        public const string specialTaxHigherRateCodeWeb = "Higher tax rate";
        public const string specialTaxSelectedYes = "yes";
        public const string specialTaxSelectedNo = "no";
        public const string workflowProcessModelCodeLA = "livingAnnuityTax";
        public const string specialTaxWorkFlowJourneyNewBusiness = "New Business";
        public const string specialTaxWorkFlowJourneyNewBusinessOther = "New Business Other";
        public const string specialTaxWorkFlowJourneyAnnuityMaintenance = "Annuity maintenance";

        public const string clientTaxTypeCode = "IPHF";
        public const string clientTaxTypeCodeType = "TXCT";
        public const string clientCompanyTaxTypeCode = "CPHF";
        public const string capitalGainTaxIPFCode = "ICGT";
        public const string capitalGainTaxCPFCode = "CCGT";
        public const string capitalGainTaxEndowmentTransactionCode = "CGTE";

        public static Dictionary<string, string> GetCountryRatesTypeCodeByTaxCode = new Dictionary<string, string>
    {
      { clientTaxTypeCode, capitalGainTaxIPFCode}, // IPHF => ICGT
			{ clientCompanyTaxTypeCode, capitalGainTaxCPFCode},// CPHF => CCGT
		};

        public const string accountApplicationId = "A01";

        public const string accountApplicationStatusCode = "PEND";
        public const string accountApplicationStatusCodeType = "ASTA";

        public const string adviserGroupRelationshipTypeName = "Adviser";
        public const string adviserGroupRelationshipTypeCode = "INIT";

        public const string profileFunctionDFIVIdentifierCode = "DFIV";
        public const string profileFunctionRCONIdentifierCode = "RCON";

        public const string patternMethodPERCCode = "PERC";
        public const string patternMethodPTMECodeType = "PTME";

        public const string amountCurrencyCode = "ZAR";

        #endregion Client application constants

        #region AccountTransactionList

        public const string CONTCode = "CONT";
        public const string TECTCode = "TECT";
        public const string PENSCode = "PENS";
        public const string RBALCode = "RBAL";
        public const string PLTFCode = "PLTF";
        public const string PRTFCode = "PTRF";
        public const string RRINCode = "RRIN";
        public const string ADJMCode = "ADJM";

        #endregion AccountTransactionList

        #region Bank Validation

        public const string pendingNotVerified = "VNVR";
        public const string manual = "VAMU";
        public const string unverified = "VNPN";
        public const string active = "ACTV";
        public const string declined = "DECL";
        public const string deletePending = "DELP";
        public const string bankServeActive = "Y";
        public const string invalid = "N";
        public const string bankServeUnverified = "U";
        public const string pending = "PEND";
        public const string CodeAndCodeTypeBank = "BANK";
        public const string SaveBank = "SAVE";

        public const string validatedNotVerified = "VNVR";
        public const string validationPendingNotVerified = "VNPN";
        public const string manualValidationPendingNotVerified = "VAMU";
        public const string validationPendingVerified = "VPVR";
        public const string manualValidationPendingVerified = "VAMR";

        public const string realTimeValidationResponse = "Account validation successful.";
        public const string pendingValidationResponse = "The clients banking details are being validated and the status will be updated shortly. You may continue with your journey. Please note that you will need to re-enter details if the validation is unsuccessful.";
        //public const string manualValidationResponse = "The clients banking details are being validated and the status will be updated shortly. You may continue with your journey. Please note that you will need to re-enter details if the validation is unsuccessful.";
        public const string duplicateBankAccoundFound = "Please Note: This account is already listed with another account holder";
        public const string errorValidationResponse = "Invalid bank account details entered";
        public const string errorInvalidRealtimeValidationResponse = "The bank details entered are invalid. Please check the following details:";
        public const string invalidBankDetailResponse = "The bank details entered are invalid. Please check the following details:\n <br>";
        public const string manualBankValidationResponse = "Your client’s bank details are being validated and the status will be updated shortly. If the validation is unsuccessful, we’ll contact you to re-enter the details.";
        public const string realtimeBankValidationResponse = "The bank account was successfully added";
        public const string invalidDebitOrCreditResponse = "This account does not accept debits or credits. Please contact us if you need to add this bank account";
        public const string realtimeDebitOrCreditNotAcceptedResponse = "The bank account was successfully added, however please note the following:\n <br>";
        #endregion Bank Validation

        #region Top-Up excluded products
        public const string PensionPres = "Pension Pres";
        public const string ProvidentPres = "Provident Pres";
        #endregion

        #region Account Maintenance
        public const string regularContributionType = "Regular Contribution";
        public const string regularWithdrawalType = "Regular Withdrawal";
        public const string regularWithdrawalProfile = "Regular Withdrawals";

        public const string regularWithdrawalValidateStartDateSpecifyBankAccountResponse = "A bank account must be specified";
        public const string regularWithdrawalValidateStartDateContravenesNoticeResponse = "Contravenes advance notice required";
        public const string regularWithdrawalValidateStartDateStatusCode = "REG";
        public const string regularWithdrawalValidateStartDateStatusCodeType = "CONT";


        public const string livingAnnuity = "Living Annuity";
        public const string profileFunctionIdentifierCodeDFIV = "DFIV";

        #region Withdrawals Journey
        // Trade Instruction Basis Section
        public const string tradeInstructionBasisCode_TRIB = "TRIB";
        public const string netProrata_CMIX = "CMIX";
        public const string grossProrata_GRPR = "GRPR";
        public const string grossAssetAmount_GAMT = "GAMT";
        public const string grossPercentageUnits_GPUN = "GPUN";
        public const string netAssetAmount_NAMT = "NAMT";
        public const string netPaymentAmount_NPAM = "NPAM";
        public const string grossUnits_GUNT = "GUNT";
        // Withdrawal Method Section
        public const string withdrawalMethodCode = "WMTH";
        public const string withdrawal_WGRS = "WGRS";
        public const string withdrawalNetAmount_WNET = "WNET";
        // Withdrawal Reason Section
        public const string withdrawalReasonCode = "TRRW";
        public const string withdrawalReasonFullWithdrawalCode = "FULW";
        public const string withdrawalReasonPartialWithdrawalCode = "PWDL";
        public const string withdrawalReasonEmigrationCode = "EMIE";
        #endregion

        #endregion

        #region Annuity Income
        public const string pensionPaymentRuleCode = "LA";
        public const string pensionPaymentRuleCodeType = "PPPR";
        public const string reviewTypePercentageCode = "PPER";
        public const string reviewTypeAmountCode = "PNOM";
        public const string reviewTypeCodeType = "PRVI";
        public const string reviewFrequencyCode = "1ANN";
        public const string taxFreeMethodCode = "TFP";
        public const string taxFreeMethodCodeType = "PTFM";
        // incomeRangeCode updated to 'LA1' as per DEFECT-1046, was 'LA3'
        public const string incomeRangeCode = "LA1";
        public const string incomeRangeCodeType = "PVFT";
        public const string annuityIncomePercentage = "percentage";
        public const string annuityIncomeAmount = "amount";
        public const string annuityIncomeTransTypeARPP = "ARPP";
        public const string annuityIncomePAYETax = "PAYE Tax";
        #endregion

        #region DFM

        public const string modelPortfolioDFMOutletCode = "1DFM";
        public const string modelPortfolioRICLocationCode = "1RIC";
        public const string adviserOutletGenVarLocationCode = "LCNO";
        public const string modelPortfolioDFMFirmReferenceCode = "OUTL";

        #endregion

        #region clientReviewHTMLTemplates

        // Heading
        public const string investmentReviewHeading = "INVESTMENT REVIEW";

        // Client
        public const string clientDateofBirth = "Date of birth";
        public const string financialAdviser = "Financial Adviser:";

        // Adviser
        public const string adviserBrokerage = "Brokerage:";
        public const string adviserContactNo = "Contact no:";
        public const string adviserEmail = "email:";

        // DIM
        public const string DIM = "DIM";
        public const string DIMFSPno = "FSP No:";

        // Account Summary
        public const string accountSummaryHeading = "ACCOUNT SUMMARY";
        public const string accountInceptionDate = "Account inception date:";
        public const string accountAllocationColumnHeading = "ALLOCATION";
        public const string accountRandAmountColumnHeading = "RAND AMOUNT";

        // Transaction Summary
        public const string transactionSummaryHeading = "TRANSACTION SUMMARY";
        public const string transactionSummaryStatement = "This shows your transaction summary for the selected period.  This is not a detailed breakdown of all transactions. For more detail, refer to your latest statement.";
        public const string transactionSummaryDetailedBreakdown = "*For detailed breakdown of your fees, go to “Your fees in more detail“ section below.";
        public const string transactionSummaryCurrentValueColumnHeading = "Current Value";
        public const string transactionSummaryCurrentValueRandColumnHeading = "R";
        public const string transactionSummaryContributions = "Contributions ";
        public const string transactionSummaryWithdrawals = "Withdrawals";
        public const string transactionSummaryFees = "Fees*";

        public const string beneficiaryCode = "BENE";


        #endregion

        // Max Search Result
        public const int MaxResult = 0;

        // Default retirement Age
        public const int defaultRetirementAge = 55;

        #region Morningstar

        public const string PortfolioXrayPDFUrl = "http://lt.morningstar.com/qjacnq8cjz/xraypdf/default.aspx?LanguageId=en-ZA&CurrencyId=ZAR";
        public const string FundMappingUrl = "https://lt.morningstar.com/api/rest.svc/qjacnq8cjz/security/screener?page=1&pageSize=10000&sortOrder=LegalName%20asc&outputType=json&version=1&languageId=en-GB&currencyId=ZAR&universeIds=FOZAF%24%24OFS_2428%7CFOZAF%24%24ONS_2428&securityDataPoints=SecId%7Cisin&filters=&term=";
        public const string CashSecurityId = "CASH000000";
        #endregion

        #region Morningstar Rest API Request

        public const string HeaderNameContentType = "Content-Type";
        public const string HeaderValueContentType = "application/x-www-form-urlencoded";
        public const string ParameterNamePortfolio = "portfolio";

        public const string HeaderNameCookie = "Cookie";
        public const string HeaderValueCookie = "ASP.NET_SessionId=mow0hem0hgtuuokw2rkqvo0j";

        #endregion

        #region MorningstarXML

        public const string RootNode = "Portfolio";
        public const string RootNodeAttributeFormatVersion = "formatVersion";
        public const string RootNodeAttributeValueFormatVersion = "2";

        public const string ExternalIdNode = "ExternalId";

        public const string CurrencyIdNode = "CurrencyId";
        public const string CurrencyIdNodeInnerTextZAR = "ZAR";

        public const string BenchmarkIdNode = "BenchmarkId";

        public const string NameNode = "Name";
        public const string NameNodeInnerText = "-";

        public const string TypeNode = "Type";
        public const string TypeNodeInnerText = "WatchListByWeighting";

        public const string HoldingsNode = "Holdings";

        public const string HoldingNode = "Holding";

        public const string SecurityIdNode = "SecurityId";

        public const string SecurityTypeNode = "SecurityType";
        public const string SecurityTypeNodeInnerTextFO = "FO";

        #endregion

        #region RuleEngine error messages
        public const string PreviousWithdrawalOtherThanGIPRuleMessage = "A withdrawal was already taken on this benefit. You may not withdraw again before the client retires.";
        public const string PreviousWithdrawalWithEmployerMessage = "This investment is not eligible for a pre-retirement withdrawal.";
        public const string RetirementAnnuityFullWithdrawalMinimumAmountRuleMessage = "You may only withdraw from a retirement annuity if the value is R{0} or less.";
        public const string LegislativeMinimumAmountForLARuleMessage = "You may not withdraw from this annuity policy, unless the value of the investment is below the legislated minimum amount of R{0}.";
        public const string MaximumNumberOfWithdrawalForPEandPRruleMessage = "You have exceeded the maximum number of withdrawals on the policy.";
        public const string WithdrawDuringRestrictionPeriodRuleMessage = "A withdrawal has already taken place on this investment. You may not withdraw again within the first 5 years of this policy.";
        public const string MaximumNumberOfWithdrawalForIAandTFSAandLARuleMessage = "You have exceeded the maximum number of withdrawals on the policy.";
        public const string MaximumNumberOfWithdrawalForEndowAndSinkRuleMessage = "You have exceeded the maximum number of withdrawals on the policy.";
        public const string DirectDebitInvestmentDayClearanceRuleMessage = "You cannot withdraw more that the available amount specified.";

        public const string BRA_30000400 = "BRA_30000400";
        public const string BRA_30000385 = "BRA_30000385";
        public const string BRA_30000380 = "BRA_30000380";
        public static Dictionary<string, string> GenericErrorMessages = new Dictionary<string, string>
    {
      { BRA_30000385, "The withdrawal value you selected exceeds the allowed limit during the 5 year restricted period. Please adjust the withdrawal value to a maximum of R{0}." },
      { BRA_30000400, "You cannot withdraw more than the available amount."},
      { BRA_30000380, WithdrawDuringRestrictionPeriodRuleMessage},

    };

        #endregion

        #region WhiteLabel Theme

        public const string INN8ThemeCode = "INN8 Branded";
        public const string StandardBankThemeCode = "SBSAWI";

        public static Dictionary<string, string> INN8ThemeStyleConstant()
        {
            return new Dictionary<string, string>()
      {
        { "$color-1", "#182969"},
        { "$color-2", "#4DC6E3"},
        { "$color-3", "#58595b"},
        { "$color-4", "#ffffff"},
        { "$color-5", "#0d96d4"},
        { "$color-6", "#999999"},
        { "$color-7", "#F32013"},
        { "$text-font", "Muli, sans-serif"}
      };
        }

        public static Dictionary<string, string> StandardBankThemeStyleConstant()
        {
            return new Dictionary<string, string>()
      {
        {"$color-1", "#0033A1"},
        {"$color-2", "#00A1E0"},
        {"$color-3", "#58595b"},
        {"$color-4", "#ffffff"},
        {"$color-5", "#00A1E0"},
        {"$color-6", "#999999"},
        {"$color-7", "#F32013"},
        {"$text-font", "arial"}
      };
        }
        #endregion

        #region Product Disclaimer URLs

        #region INN8 Product Terms URLs

        public static IDictionary<string, string> INN8DisclaimerUrls = new Dictionary<string, string>()
    {
        {ProductTypes.investmentAccount, "https://inn8.co.za/secure/?s=InvestmentAccount"},
        {ProductTypes.taxFreeSavingsAccount, "https://inn8.co.za/secure/?s=TFSA"},
        {ProductTypes.endowment, "https://inn8.co.za/secure/?s=Endowment"},
        {ProductTypes.sinkingFund, "https://inn8.co.za/secure/?s=SinkingFund"},
        {ProductTypes.retirementAnnuity, "https://inn8.co.za/secure/?s=RetirementAnnuity"},
        {ProductTypes.pensionPreservation, "https://inn8.co.za/secure/?s=PensionPres"},
        {ProductTypes.providentPreservation, "https://inn8.co.za/secure/?s=ProvidentPres"},
        {ProductTypes.livingAnnuity, "https://inn8.co.za/secure/?s=LivingAnnuity"}
    };

        #endregion

        #region Standard Bank Product Terms URLs

        // Commented out for now. Will use when Standard Bank functionality is required.

        //public static IDictionary<string, string> StandardBankDisclaimerUrls = new Dictionary<string, string>()
        //{
        //    {ProductTypes.investmentAccount, ""},
        //    {ProductTypes.taxFreeSavingsAccount, ""},
        //    {ProductTypes.endowment, ""},
        //    {ProductTypes.sinkingFund, ""},
        //    {ProductTypes.retirementAnnuity, ""},
        //    {ProductTypes.pensionPreservation, ""},
        //    {ProductTypes.providentPreservation, ""},
        //    {ProductTypes.livingAnnuity, ""}
        //};
        #endregion

        #endregion

        #region ClientProxy
        public static string[] clientProxyRelationshipTypes = new string[] { "OWN", "GPOA", "GRDN", "1PRT" };
        #endregion

        #region Activity Tracking
        // Withdrawal Process activity status code
        public const string activityTypeCodeWithdrawalProcess = "Withdrawal";
        public const string activityTypeCodeNewBusiness = "New Business";
        public const string activityTypeCodeAll = "ALL";
        // Workflow statuses
        public const string statusFICADocsOutstanding = "FICA documentation outstanding";
        public const string statusFICADocsReceived = "FICA documentation received";
        public const string statusFICACompleted = "FICA verified";
        public const string statusFICAProcessInitiated = "FICA process initiated";
        public const string statusAwaitingClient = "Awaiting client verification";
        public const string statusClientConfirmed = "Client verification confirmed";
        public const string statusClientOnboardingInProgress = "Client onboarding in progress";
        public const string statusRelatedPartiesOnboarding = "Related parties onboarding";
        public const string statusProcessingTransaction = "Processing transaction";
        // Withdrawal Process workflow statuses
        public const string statusProcessingInProgress = "Processing In Progress";
        public const string statusTradingInProgress = "Trading in Progress";
        public const string statusTaxDirectiveInProgress = "Tax Directive in Progress";
        public const string statusPaymentInProgress = "Payment in Progress";
        public const string statusComplete = "Complete";
        //Database constants
        public const string transactionTypeEventCodeCategoryContribution = "Contributions";
        public const string transactionTypeEventCodeCategoryWithdrawal = "Withdrawals";
        #endregion

        public const string AppSettingMaxFileSizeKey = "MaxFileSize";

        public const string FileSizeError = "File Size is greater than the allowed. Please upload a file less than ";

        public const string FileTypeError = "File type isn't allowed";

        #region AccountAnnualContributionDetails
        public const string BRA_113338 = "BRA_113338";
        public const string BRA_49033 = "BRA_49033";
        #endregion

        #region CreateAccountApplicationRest
        public const string IdentifierLevel = "IdentifierLevel";
        public const string PAYR = "PAYR";
        #endregion

        #region user (username, password, roles )

        public const string Adviser = "adviser";
        public const string DFM = "dfm";
        public const string Client = "client";


        public const string UsernameRequired = "Username is required";
        public const string UsernameErrorMessageForLength = "Usernames should be at least 7 characters and a maximum of 30 characters, must contain at least one alphabetical character and may not be an email address or be identical to your password.";
        public const string UsernameOrEmailOrPasswordRequired = "Username and password are required.";
        public const string UsernamePasswordNotIdentical = "Username and password cannot be identical.";
        public const string UsernameTakenInfo = "This username is already taken. Please try a new one.";
        public const string UsernameOrPasswordIncorrect = "Incorrect username or password.";
        public const string emailOrRoleRequired = "email address or role required.";
        public const string InvalidRole = "Invalid Role";
        #endregion

    }
}
