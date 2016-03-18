//-----------------------------------------------------------------------
// <copyright file="Const.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace PatTuring2016.Common
{
    public static class Const
    {
        public static string GetEnumName(PatomValues patomValues)
        {
            return GetEnumName((int)patomValues);
        }

        public static PatomValues GetEnumFromInt(int number)
        {
            if (Enum.IsDefined(typeof(PatomValues), number))
            {
                return (PatomValues)number;
            }

            return PatomValues.Fail;
        }

        public static string GetEnumName(int number)
        {
            if (!Enum.IsDefined(typeof(PatomValues), number))
            {
                return string.Empty;
            }

            // cast must work as tested above
            var no = (PatomValues)number;

            switch (no)
            {
                case PatomValues.Version:
                    return "0.9-a00j";

                case PatomValues.Adjlinkedclause:
                    return "Adjective Linked Clause";
                case PatomValues.Nounlinkedclause:
                    return "Noun Linked Clause";
                case PatomValues.Wherelinkedclause:
                    return "Where Linked Clause";
                case PatomValues.Whenlinkedclause:
                    return "When Linked Clause";

                case PatomValues.Complement:
                    return "COMPLEMENT";
                case PatomValues.Verbnounwhere:
                    return "Verb where noun";
                case PatomValues.Verbnounheadwhere:
                    return "Verb where noun head";
                case PatomValues.Controllernoadj:
                    return "Controller no macroroles";
                case PatomValues.Controllergerund:
                    return "Controller linking gerund";
                case PatomValues.Controlleradjgerund:
                    return "Controller linking adj to gerund";
                case PatomValues.Verbthat:
                    return "Verb that linkage";

                case PatomValues.Causeaccomplishmentnounclause:
                    return "Causative Accomplishment Clause";
                case PatomValues.Causeaccomplishmentonenounclause:
                    return "Causative Accomplishment One Clause";
                case PatomValues.PassiveCauseaccomplishmentnounclause:
                    return "Passive Causative Accomplishment Clause";
                case PatomValues.PassiveCauseaccomplishmentonenounclause:
                    return "Passive Causative Accomplishment One Clause";
                case PatomValues.Nounclauseinitial:
                    return "Initial noun clause match";
                case PatomValues.Verbwithnoun:
                    return "Noun with with marking";
                case PatomValues.Controllereageradj:
                    return "Controller verb with actor";

                case PatomValues.To:
                    return "To preposition";
                case PatomValues.With:
                    return "With preposition";
                case PatomValues.For:
                    return "For preposition";
                case PatomValues.From:
                    return "From preposition";
                case PatomValues.By:
                    return "By preposition";
                case PatomValues.Loc:
                    return "Location";

                case PatomValues.Clauseheadverb:
                    return "Clause Head Verb";
                case PatomValues.Achievementclause:
                    return "Achievement Clause";
                case PatomValues.PassiveAchievementclause:
                    return "Achievement Clause";
                case PatomValues.Activityclause:
                    return "Activity Clause";
                case PatomValues.PassiveActivityclause:
                    return "Passive Activity Clause";
                case PatomValues.LatinAddPhrase:
                    return "Latin Add Phrase";
                case PatomValues.LatinConsolidate:
                    return "Latin Consolidate";
                case PatomValues.LatinAspectPhrase:
                    return "Latin Aspect Phrase";

                case PatomValues.ActivityGerundClause:
                    return "Activity Gerund Clause";
                case PatomValues.PassiveActivityGerundClause:
                    return "Passive Activity Gerund Clause";
                case PatomValues.Verbhead:
                    return "Verb Head";
                case PatomValues.Deontic:
                    return "Deontic modality";
                case PatomValues.Epistemic:
                    return "Epistemic modality";
                case PatomValues.Particle:
                    return "Particle";
                case PatomValues.Verbtransitive:
                    return "Verb Activity Aspect";
                case PatomValues.Verbnoun:
                    return "Verb acting as noun";
                case PatomValues.Pivotverb:
                    return "Verb pivot";
                case PatomValues.Determiner:
                    return "Determiner";

                case PatomValues.Verbwhen:
                    return "Verb when";
                case PatomValues.Verbwhere:
                    return "Verb where";
                case PatomValues.Verblinkadj:
                    return "Verb link to adjective";
                case PatomValues.Verblinkfulladj:
                    return "Full verb link to adjective";
                case PatomValues.Controllernomradj:
                    return "Controller linking adjective";
                case PatomValues.Semelfactivexynounclause:
                    return "Semelfactive Noun headed clause";
                case PatomValues.PassiveSemelfactivexynounclause:
                    return "Passive Semelfactive Noun headed clause";
                case PatomValues.Questionwhen:
                    return "When question";
                case PatomValues.Questionwhere:
                    return "Where question";
                case PatomValues.VerbSeparable:
                    return "Separable Verb";

                case PatomValues.Accomplishmentnounclause:
                    return "Accomplishment Noun Clause";
                case PatomValues.Achievementnounclause:
                    return "Achievement Noun Clause";
                case PatomValues.Activitynounclause:
                    return "Activity Noun Clause";

                case PatomValues.PassiveAccomplishmentnounclause:
                    return "Passive Accomplishment Noun Clause";
                case PatomValues.PassiveAchievementnounclause:
                    return "Passive Achievement Noun Clause";
                case PatomValues.PassiveActivitynounclause:
                    return "Passive Activity Noun Clause";

                case PatomValues.Semelfactivexclause:
                    return "Intransitive Semelfactive Clause";
                case PatomValues.Semelfactivexyclause:
                    return "Transitive Semelfactive Clause";
                case PatomValues.PassiveSemelfactivexclause:
                    return "Passive Intransitive Semelfactive Clause";
                case PatomValues.PassiveSemelfactivexyclause:
                    return "Passive Transitive Semelfactive Clause";

                case PatomValues.Transxyclause:
                    return "2 Macrorole State Clause";
                case PatomValues.PassiveTransxyclause:
                    return "Passive 2 Macrorole State Clause";
                case PatomValues.Transxclause:
                    return "1 Macrorole State Clause";
                case PatomValues.Causeonemraccomplishmentclause:
                    return "One Macrorole Accomplishment Clause";
                case PatomValues.PassiveCauseonemraccomplishmentclause:
                    return "Passive One Macrorole Accomplishment Clause";
                case PatomValues.UndergoCauseonemraccomplishmentclause:
                    return "One Macrorole Accomplishment Clause (Undergo)";
                case PatomValues.Transxynounclause:
                    return "2 Macrorole State Noun Clause";
                case PatomValues.Transxnounclause:
                    return "1 Macrorole State Noun Clause";
                case PatomValues.PassiveTransxynounclause:
                    return "Passive 2 Macrorole State Noun Clause";

                case PatomValues.UndergoAccomplishmentclause:
                    return "Accomplishment Clause (Undergo)";
                case PatomValues.UndergoCauseaccomplishmentclause:
                    return "Cause Accomplishment Clause (Undergo)";
                case PatomValues.UndergoSemelfactivexclause:
                    return "One Macrorole Semelfactive Clause (Undergo)";
                case PatomValues.UndergoSemelfactivexyclause:
                    return "Semelfactive Clause (Undergo)";
                case PatomValues.UndergoAchievementclause:
                    return "Achievement Clause (Undergo)";
                case PatomValues.UndergoActivityclause:
                    return "Activity Clause (Undergo)";

                case PatomValues.Tomacrorole:
                    return "To Macrorole";
                case PatomValues.Frommacrorole:
                    return "From Macrorole";
                case PatomValues.Controllernomr:
                    return "Controller with No Macrorole";
                case PatomValues.Controllermake:
                    return "Make Controller Type";

                case PatomValues.Nucverb:
                    return "Nucleus verb";
                case PatomValues.Causeaccomplishmentclause:
                    return "Causative accomplishment verb";
                case PatomValues.Causeaccomplishmentposclause:
                    return "Causative accomplishment pos verb";
                case PatomValues.PassiveCauseaccomplishmentclause:
                    return "Passive Causative accomplishment verb";
                case PatomValues.Verbwithoblique:
                    return "Verb plus oblique";
                case PatomValues.VerbSeparate:
                    return "Verb separable";
                case PatomValues.Accomplishmentclause:
                    return "Accomplishment verb";
                case PatomValues.CountBlessings:
                    return "Idiomatic Count verb";
                case PatomValues.PassiveAccomplishmentclause:
                    return "Passive Accomplishment verb";
                case PatomValues.Verbtonoun:
                    return "Verb plus to";
                case PatomValues.Verbfromnoun:
                    return "Verb plus from";
                case PatomValues.Verbwhy:
                    return "Why Clause";
                case PatomValues.Closed:
                    return "Closed word";
                case PatomValues.Transbenounclause:
                    return "Be Noun Clause";
                case PatomValues.PassiveTransbenounclause:
                    return "Passive Be Noun Clause";
                case PatomValues.Verbtagquestion:
                    return "Verb Tag Question";

                case PatomValues.Verbhow:
                    return "Verb How";
                case PatomValues.Verbnot:
                    return "Verb Not";
                case PatomValues.Verbinterjection:
                    return "Verb Interjection";
                case PatomValues.Nonmacrorole:
                    return "Non macrorole";
                case PatomValues.Nounhead:
                    return "Noun Head";

                case PatomValues.Passivesubject:
                    return "Passive Subject";
                case PatomValues.Subjectofcomp:
                    return "Subject of Complement";
                case PatomValues.Wherecomplement:
                    return "Where Complement";
                case PatomValues.Clausetype:
                    return "Clause Type / IF";
                case PatomValues.Ismodal:
                    return "Modal verb";
                case PatomValues.Domodal:
                    return "Modal verb";
                case PatomValues.Verbvoice:
                    return "Verb voice";
                case PatomValues.Verbmatrix:
                    return "Verb Matrix";

                case PatomValues.Howclause:
                    return "How";
                case PatomValues.Howcore:
                    return "How";
                case PatomValues.Hownuc:
                    return "How";

                case PatomValues.Nucauxiliary:
                    return "Auxiliary";

                case PatomValues.Intrans:
                    return "Intransitive";
                case PatomValues.Trans:
                    return "Transitive";

                case PatomValues.Adjsc:
                    return "Adjective Complement";
                case PatomValues.Nounsc:
                    return "Noun Complement";
                case PatomValues.Predsc:
                    return "Predicate Complement";

                case PatomValues.Questions:
                    return "Subject question word";

                case PatomValues.Jclause:
                    return "Japanese Clause";

                case PatomValues.Yndetail:
                    return "Yes or No";

                // Attribute Forms
                case PatomValues.Adjtype:
                    return "Adjective Type";

                case PatomValues.Pastpart:
                    return "Past Participle";
                case PatomValues.Prespart:
                    return "Present Participle";

                case PatomValues.Nucleus2:
                    return "Second Nucleus";

                case PatomValues.Location2:
                    return "Location";

                case PatomValues.Materialtheme:
                    return "Material";

                case PatomValues.Predtheme:
                    return "Predicate";

                case PatomValues.Timetheme:
                    return "Time";

                case PatomValues.Verbtheme:
                    return "Verb Theme";
                case PatomValues.Clausetheme:
                    return "Clause Theme";
                case PatomValues.Senselist:
                    return "Sense List";

                case PatomValues.Clausehead:
                    return "Clause Head";

                case PatomValues.VerbNoVerb:
                    return "Verb Correction";

                case PatomValues.VerbNoMacrorole:
                    return "Macrorole Correction";

                case PatomValues.Nothing:
                    return "Nothing";

                case PatomValues.Iforce:
                    return "Illocutionary Force";

                case PatomValues.Calc:
                    return "Calc operand";

                case PatomValues.Function:
                    return "Function";

                case PatomValues.Hundred:
                    return "Hundred";

                case PatomValues.Thousand:
                    return "Thousand";

                case PatomValues.Million:
                    return "Million";

                case PatomValues.Billion:
                    return "Billion";

                case PatomValues.VerbToWhere:
                    return "Verb where";

                case PatomValues.AmPm:
                    return "AMPM";
                    
                default:
                    return no.ToString();
            }
        }

        public static int GetEnumConst(string name)
        {
            PatomValues res;
            if (Enum.TryParse(name, true, out res))
            {
                return (int)res;
            }

            return -1;
        }

        public static PatomValues GetEnum(string name)
        {
            PatomValues res;
            return Enum.TryParse(name, true, out res) ? res : PatomValues.Nothing;
        }

        public static string GetSimpleName(int currentPageType)
        {
            switch (currentPageType)
            {
                //case (int)PatomValues.Noun:
                //    return "Clause"; // nouns are the heads of clauses

                case (int)PatomValues.Verb:
                case (int)PatomValues.Predicate:
                case (int)PatomValues.Adjective:
                case (int)PatomValues.Compound:
                    return "FullScreen";
            }

            return GetEnumName(currentPageType);
        }
    }
}