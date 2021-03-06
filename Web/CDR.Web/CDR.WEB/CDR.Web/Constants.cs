﻿using CDR.Web.Api;
using CDR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace CDR.Web
{
    public static class Constants
    {
        public const string SUBREQUESTURL = "SubRequest/";
        public const string OWNERURL = "Sub_Owner";

        public const string SUBREPRESENTATIVELOOKUPURL = "SubLookupRepresentative";
        public const string SUBFEELOOKUPURL = "SubLookupFee";
        public const string SUBSTATUSLOOKUPURL = "SubLookupStatus";
        public const string SUBREQUESTTYPELOOKUPURL = "SubLookupRequestType";
        public const string SUBLOANTYPELOOKUPURL = "SubLookupLoanType";

        public const string GETASSIGNEMNTS = "AsmAssignments/Account_Number?=";
        public const string UPDATEASSIGNMENT = "AsmAssignments/Update";
        public const string GETCFODETAILSBYID = "api/CFOCheckIn/AcctNo?=";
        public const string GETCUSTODIANDETAILS = "GTAResults/?accountNumber=";


        public const string ASMASSIGNEDTOLOOKUPURL = "AsmLookupAssignedTo/";
        public const string ASMDOCTYPELOOKUPURL = "AsmLookupDocType/";
        public const string ASMENTEREDBYLOOKURL = "AsmLookupEnteredBy/";
        public const string ASMPROCESSEDBYLOOKUPURL = "AsmLookupProcessedBy/";
        public const string ASMPROCESSORNAMELOOKUPURL = "AsmLookupProcessorName/";
        public const string ASMPREPAREDBYLOOKUPURL = "AsmLookupPreparedBy/";
        public const string ASMRECORDINGSTATUSLOOKUPURL = "AsmLookupRecordingStatus/";
        public const string ASMREQUESTORNAMELOOKUPURL = "AsmLookupRequestorName/";
        public const string ASMREQUESTREASONLOOKUPURL = "AsmLookupRequestReason/";
        public const string ASMREQUESTTYPELOOKUPURL = "AsmLookupRequestType/";
        public const string ASMSTATUSLOOKUPURL = "AsmLookupStatus/";
    }
}