using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels.PartDisplays;
using PatTuring2016.Common.ScreenModels.FullScreenModels;
using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(SentencesScreenModel))]
    [KnownType(typeof(FullScreenModel))]
    [KnownType(typeof(StandardScreenModel))]
    [KnownType(typeof(FullClauseScreenModel))]
    [KnownType(typeof(FullNounScreenModel))]
    [KnownType(typeof(SenseScreenModel))]
    [KnownType(typeof(WordScreenModel))]
    [KnownType(typeof(PhraseScreenModel))]
    [KnownType(typeof(SensesScreenModel))]
    [KnownType(typeof(AbstractPartDisplay))]
    [KnownType(typeof(SentenceScreenModel))]
    [KnownType(typeof(TopScreenModel))]
    [KnownType(typeof(TextPartDisplay))]
    [KnownType(typeof(TextListPartDisplay))]
    [KnownType(typeof(SenseListModel))] 
    [KnownType(typeof(NewBasePartDisplay))]
    [DataContract]
    public class GetScreenResponse : Response
    {
        [DataMember]
        public FullScreenModel ScreenModel { get; set; }

        [DataMember]
        public string ScreenName { get; set; }

        [DataMember]
        public bool LastScreen { get; set; }

        [DataMember]
        public bool SimpleView { get; set; }
    }
}
