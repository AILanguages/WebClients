//-----------------------------------------------------------------------
// <copyright file="PatomValues.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PatTuring2016.Common
{
    public enum PatomValues
    {
        Word = 0, // used for words - obsolete
        Noun = 1, // used for words representing phrases
        Verb = 2, // used for words representing phrases
        Determiner = 3,
        Compound = 4, // compound phrases
        First = 5, // first compound element
        Second = 6, // second compound element
        Third = 7, // third compound element
        Fourth = 8, // fourth compound element
        Base = 9, // used for base blobs (i.e. generic)
        Sense = 10, // used for a single sense

        Interjection = 11,
        Gerund = 12, // used for words representing phrases
        Adjective = 13, // used for words representing phrases
        How = 14, // used for words representing phrases
        When = 15, // used for words representing phrases
        Where = 16, // used for words representing phrases
        Preposition = 17, // used for words representing phrases
        DeterminerHead = 18,
        Negative = 19,

        Question = 20, // used for question words and phrases
        Which = 21, // used for question words and phrases
        Hidden = 22, // used for question words and phrases
        Prefix = 23, // used for question words and phrases
        Senses = 24, // used for multiple senses
        Verbtype = 25, // identifies a specific set of verb patterns
        Nountype = 26, // identifies a specific set of noun patterns
        Postposition = 27, // identifies a postposition (cf preposition)

        Is = 28, // who IS running
        Has = 29, // John'S house
        Of = 30, // noun OF noun
        Was = 31, // who WAS 
        Does = 32, // who DOES

        Clause = 33,
        Jclause = 34,
        Headedclause = 35,
        Sentence = 36,
        That = 37,
        Relative = 39,
        Conjunction = 40,
        Inflection = 41,
        Passivesubject = 42,
        Subjectofcomp = 43,
        Why = 44,
        Wherecomplement = 45,
        Pivotverb = 47,
        Pivot = 48,

        Comparitive = 50, // comparitive object, happier than "the dog"
        Fullword = 52, // used for words - obsolete
        PSA = 53,

        Title = 54, // used for titles and phrases
        List = 55, // used for titles and phrases
        Literal = 56, // used for literal phrases

        Clausehead = 59,
        Quantity = 60,
        Language = 61,

        Modal = 66, // the modal word in a clause - flipped with questions
        Subject = 67, // for phrases that don't link on their own 
        Predicate = 68, // for phrases that don't link on their own 
        Yndetail = 69,

        // Pattern types
        Multiphrase = 70,
        Multidenseanyphrase = 72, // this can replace all dense multi phrases
        Simplephrase = 73,
        Multidensephrase = 74,
        Phrase = 75,

        Adjsc = 76,
        Nounsc = 77,
        Predsc = 78,

        // Attribute Forms
        Personclause = 89,
        Time = 90, // attributes denoting time in verbs
        Tense = 91, // attributes denoting tense in verbs

        Gender = 93, // attributes denoting gender
        Person = 94, // attributes denoting person, singular or plural)
        Thing = 95, // attributes denoting titles and things
        Sign = 96, // attributes for positive and negative 
        Adjtype = 97, // attributes for adjectives
        Status = 98, // attributes for status, like if a verb is full

        // ADJECTIVE TYPES - USED FOR MAPPING
        Cardinal = 100,
        Opinion = 101,
        Size = 102,
        Length = 103,
        Shape = 104,
        Width = 105,
        Pastpart = 106,
        Prespart = 107,
        Age = 108,
        Colour = 109,
        Origin = 110,
        Material = 111,
        Denominal = 112,
        Auxiliary = 113,
        Clausetype = 114,
        Nucauxiliary = 115,
        Verbtransitive = 116,
        Nucverb = 117,
        Semelfactivexclause = 118,
        Semelfactivexyclause = 119,

        // THEMATIC ROLES
        Actor = 120,
        Agent = 121,
        Asset = 122,
        Attribute = 123,
        Beneficiary = 124,
        Cause = 125,
        Location = 126,
        Destination = 127,
        Source = 128,
        Location2 = 129,
        Experiencer = 130,
        Extent = 131,
        Instrument = 132,
        Materialtheme = 133,
        Product = 134,
        Patient = 135,
        Predtheme = 136,
        Recipient = 137,
        Stimulus = 138,
        Theme = 139,
        Timetheme = 140,
        Topic = 141,
        Verbtheme = 142,
        Oblique = 143,
        Closed = 144,
        Sentences = 145,
        Clausetheme = 146,
        Senselist = 147,
        Undergoer = 148,
        Nucleus = 149,

        Uses = 150,
        Passive = 151,
        Verbaspect = 152,
        Intrans = 153,
        Trans = 154,

        Iforce = 157,
        Adjlinkedclause = 158,
        Nounlinkedclause = 159,
        Wherelinkedclause = 160,
        Link = 161,
        Complement = 162,
        Whenlinkedclause = 163,

        Verbhow = 164,
        Verbnot = 165,
        Verbinterjection = 166,
        Hownuc = 167,
        Howcore = 168,
        Howclause = 169,
        Clauseheadverb = 170,
        Ismodal = 171,
        Domodal = 172,
        Achievementclause = 174,
        Achievementxyclause = 175,
        Activityclause = 176,

        Whenclause = 178,
        Whereclause = 179,
        Verbwhy = 180,
        Nonmacrorole = 181,
        Frommacrorole = 182,
        Tomacrorole = 183,

        Macrorole = 185,
        Verbvoice = 187,
        Verbhead = 188,
        Deontic = 189,
        Epistemic = 190,
        Particle = 191,
        Verbnoun = 192,

        Version = 193,
        Questiona = 194,
        Questionu = 195,
        Questionn = 196,
        Verbwhere = 199,
        Verbwhen = 200,
        Causeaccomplishmentclause = 203,
        Verbwithoblique = 204,
        Accomplishmentclause = 206,
        Verbmatrix = 208,
        Verblinkadj = 209,
        Controllernomr = 210,
        Controllermake = 211,
        Controllernomradj = 212,
        Transxyclause = 213,
        Causeonemraccomplishmentclause = 214,
        Nounhead = 215,
        Transxynounclause = 216,
        Semelfactivexynounclause = 217,

        Achievementnounclause = 218,
        Accomplishmentnounclause = 219,
        Activitynounclause = 220,

        Questions = 221,
        Causeaccomplishmentonenounclause = 222,
        Verbwithnoun = 223,
        Causeaccomplishmentnounclause = 224,

        To = 225,
        With = 226,
        For = 227,
        From = 228,
        By = 229,
        Loc = 230,
        Nounclauseinitial = 231,
        Verbfromnoun = 232,
        Verbtonoun = 233,
        Transbenounclause = 234,

        Verbnounwhere = 235,
        Verbnounheadwhere = 236,

        Questionwhen = 237,
        Questionwhere = 238,

        Controllernoadj = 239,
        Controllereageradj = 240,
        Verbtagquestion = 241,

        Questiont = 242,
        Questionf = 243,
        Verblinkfulladj = 244,
        Nucleus2 = 245,
        Controllergerund = 246,
        Controlleradjgerund = 247,
        Verbthat = 248,
        Fail = 249,
        MatrixThatClause = 250,
        ClauseEllipsis = 251,
        ClauseMatrix = 252,
        ClauseShort = 253,
        ClauseNounEllipsis = 254,
        Adjective2 = 255,
        Positive = 256, // attributes for status, like if a verb is full
        Undergoer2 = 300,
        Sentence2Join = 301,
        SentenceIf = 302,
        Actor2 = 303,
        SentenceBecause = 304,
        Noun2 = 305,
        Deixis = 306,
        Npip = 307,
        AdjectiveHead = 308,

        ActivityGerundClause = 309,
        PassiveActivityGerundClause = 310,

        LatinAddPhrase = 311,
        LatinConsolidate = 312,
        LatinAspectPhrase = 313,
        GermanVerbAspect = 314,
        GermanClausehead = 315,
        GermanDativeVerb = 316,

        UndergoAccomplishmentclause = 350,
        UndergoCauseaccomplishmentclause = 351,
        UndergoCauseonemraccomplishmentclause = 352,
        UndergoSemelfactivexclause = 353,
        UndergoSemelfactivexyclause = 354,
        UndergoAchievementclause = 355,
        UndergoActivityclause = 356,
        UndergoerVerbClauseIntersect = 357,

        PassiveSemelfactivexclause = 358,
        PassiveSemelfactivexyclause = 359,
        PassiveAchievementclause = 360,
        PassiveAccomplishmentclause = 361,
        PassiveCauseaccomplishmentclause = 362,
        PassiveCauseonemraccomplishmentclause = 363,
        PassiveActivityclause = 364,

        PassiveTransxynounclause = 365,
        PassiveSemelfactivexynounclause = 366,
        PassiveAchievementnounclause = 367,
        PassiveAccomplishmentnounclause = 368,
        PassiveActivitynounclause = 369,
        PassiveCauseaccomplishmentonenounclause = 370,
        PassiveCauseaccomplishmentnounclause = 371,
        PassiveTransbenounclause = 372,

        PassiveTransxyclause = 373,
        PassiveMatrixThatClause = 374,
        Transxclause = 375,
        ControllerState = 376,

        ActorPronoun = 377, // used to show actual noun when pronoun used
        UndergoerPronoun = 378,
        NmrPronoun = 379,
        VerbSeparable = 380,
        Clauseheadphrasalverb = 381,
        NucleusPrep = 382,
        VerbOnlyHow = 383,
        VerbSeparate = 384,
        Nounclauseend = 385,
        Nounclauseupdate = 386,
        Causeaccomplishmentposclause = 387,
        CountBlessings = 388,
        Nothing = 389,
        NounClause = 390,
        Transxnounclause = 391,
        EmbeddedClause = 392,
        VerbNoVerb = 393,
        VerbNoMacrorole = 394,
        VerbNoVerbNewHead = 395,
        HeadError = 396,
        ClauseEllipsisNot = 397,
        Calc = 398,
        Function = 399,
        Number = 400,
        Hundred = 401,
        Thousand = 402,
        Million = 403,
        Billion = 404,
        VerbToWhere = 405,
        NucleusVerb = 406,
        NucleusNoun = 407,
        NucleusAdj = 408,
        NucleusWhen = 409,
        NucleusWhere = 410,
        Adjwhere = 411,
        NounBaseLinkedClause = 412,
        Date = 413,
        DateTime = 414,
        AmPm = 415
    }
}