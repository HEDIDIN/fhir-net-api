/* 
 * Copyright (c) 2016, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Linq;
using System.Collections.Generic;
using Hl7.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;

namespace Hl7.Fhir.Validation
{

    internal delegate bool Condition();

    internal static class OperationOutcomeExtensions
    {
        public static bool Verify(this OperationOutcome outcome, Condition condition, string message, Issue issue, INamedNode location)
        {
            if (!condition())
            {
                outcome.AddIssue(issue.ToIssueComponent(message, location));
                return false;
            }
            else
                return true;
        }

        public static void Info(this OperationOutcome outcome, string message, Issue infoIssue, INamedNode location)
        {
            outcome.AddIssue(infoIssue.ToIssueComponent(message, location));
        }

        public static void Info(this OperationOutcome outcome, string message, Issue infoIssue, string location)
        {
            outcome.AddIssue(infoIssue.ToIssueComponent(message, location));
        }


        public static void MakeInformational(this OperationOutcome outcome)
        {
            //var result = (OperationOutcome)outcome.DeepCopy();
            var result = outcome;

            foreach (var issue in result.Issue)
                issue.Severity = OperationOutcome.IssueSeverity.Information;
        }

        public static void Flatten(this OperationOutcome outcome)
        {
            foreach(var issue in outcome.Issue)
            {
                issue.RemoveExtension(ValidationOutcomeExtensions.OPERATIONOUTCOME_ISSUE_HIERARCHY);
            }
        }
    }

}