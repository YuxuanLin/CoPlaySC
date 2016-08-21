using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CoPlaySC.Models
{
    public enum SuburbEnum
    {
        CURRENT,
        ABBOTSFORD,
        ABERFELDIE,

        [Display(Name = "AIRLEYS INLET")]
        AIRLEYSINLET,

        [Display(Name = "AIRPORT WEST")]
        AIRPORTWEST,

        ALBANVALE,

        [Display(Name = "ALBERT PARK")]
        ALBERTPARK,

        [Display(Name = "ALBERTON WEST")]
        ALBERTONWEST,

        ALBION,
        ALEXANDRA,
        ALFREDTON,

        [Display(Name = "ALLANS FLAT")]
        ALLANSFLAT,

        ALLANSFORD,
        ALPHINGTON,
        ALTONA,

        [Display(Name = "ALTONA MEADOWS")]
        ALTONAMEADOWS,

        [Display(Name = "ALTONA NORTH")]
        ALTONANORTH,

        ALVIE,
        AMPHITHEATRE,
        ANAKIE,
        ANGLESEA,

        [Display(Name = "APOLLO BAY")]
        APOLLOBAY,

        APSLEY,
        ARARAT,
        ARDEER,
        ARDMONA,
        ARMADALE,

        [Display(Name = "ARTHURS CREEK")]
        ARTHURSCREEK,

        [Display(Name = "ASCOT VALE")]
        ASCOTVALE,

        ASHBURTON,
        ASHWOOD,
        ASPENDALE,
        ATHLONE,
        AVENEL,
        AVOCA,

        [Display(Name = "AVONDALE HEIGHTS")]
        AVONDALEHEIGHTS,

        AVONSLEIGH,
        AXEDALE,

        [Display(Name = "BACCHUS MARSH")]
        BACCHUSMARSH,

        BAGSHOT,
        BAIRNSDALE,
        BAKER,
        BALLAN,
        BALLARAT,

        [Display(Name = "BALLARAT EAST")]
        BALLARATEAST,

        [Display(Name = "BALLARAT NORTH")]
        BALLARATNORTH,

        BALLIANG,
        BALMORAL,
        BALNARRING,

        [Display(Name = "BALNARRING BEACH")]
        BALNARRINGBEACH,

        BALWYN,

        [Display(Name = "BALWYN NORTH")]
        BALWYNNORTH,

        BAMAWM,
        BAMBRA,

        [Display(Name = "BANDIANA MILPO")]
        BANDIANAMILPO,

        BANGHOLME,
        BANNOCKBURN,
        BANYENA,
        BARANDUDA,
        BARINGHUP,
        BARINHUP,
        BARMAH,
        BARNAWARTHA,
        BARONGAROOK,
        BARRABOOL,

        [Display(Name = "BARUNAH PARK")]
        BARUNAHPARK,

        [Display(Name = "BARWON DOWNS")]
        BARWONDOWNS,

        [Display(Name = "BARWON HEADS")]
        BARWONHEADS,

        BASS,
        BATESFORD,
        BAYSWATER,

        [Display(Name = "BAYSWATER NORTH")]
        BAYSWATERNORTH,

        BEACONSFIELD,
        BEALIBA,
        BEARII,

        [Display(Name = "BEARS LAGOON")]
        BEARSLAGOON,

        BEAUCHAMP,
        BEAUFORT,
        BEAUMARIS,
        BEEAC,

        [Display(Name = "BEECH FOREST")]
        BEECHFOREST,

        BEECHWORTH,
        BELBRIDGE,
        BELGRAVE,

        [Display(Name = "BELGRAVE SOUTH")]
        BELGRAVESOUTH,

        [Display(Name = "BELL PARK")]
        BELLPARK,

        [Display(Name = "BELL POST HILL")]
        BELLPOSTHILL,

        BELLBRAE,
        BELMONT,
        BENA,
        BENALLA,
        BENAMBRA,
        BENDIGO,

        [Display(Name = "BENDIGO EAST")]
        BENDIGOEAST,

        BENNETTSWOOD,
        BENNISON,
        BENTLEIGH,

        [Display(Name = "BENTLEIGH EAST")]
        BENTLEIGHEAST,

        BERRIWILLOCK,
        BERWICK,
        BETHANGA,
        BEULAH,
        BEVERIDGE,
        BINGINWARRI,
        BIRCHIP,
        BIRREGURRA,
        BITTERN,

        [Display(Name = "BLACK HILL")]
        BLACKHILL,

        [Display(Name = "BLACK ROCK")]
        BLACKROCK,

        BLACKBURN,

        [Display(Name = "BLACKBURN NORTH")]
        BLACKBURNNORTH,

        [Display(Name = "BLACKBURN SOUTH")]
        BLACKBURNSOUTH,

        BLACKWOOD,
        BLAIRGOWRIE,
        BOISDALE,
        BOLWARRA,
        BONBEACH,
        BONEGILLA,
        BONEO,

        [Display(Name = "BONNIE DOON")]
        BONNIEDOON,

        BOOLARRA,
        BOORHAMAN,
        BOORT,
        BORONIA,
        BOWENVALE,

        [Display(Name = "BOX HILL")]
        BOXHILL,

        [Display(Name = "BOX HILL NORTH")]
        BOXHILLNORTH,

        [Display(Name = "BOX HILL SOUTH")]
        BOXHILLSOUTH,

        BRAESIDE,
        BRANXHOLME,
        BRAYBROOK,
        BREAKWATER,
        BREAMLEA,
        BREMLEA,
        BRIAGOLONG,

        [Display(Name = "BRIDGEWATER ON LODDON")]
        BRIDGEWATERONLODDON,

        BRIGHT,
        BRIGHTON,

        [Display(Name = "BRIGHTON EAST")]
        BRIGHTONEAST,

        BRIM,
        BROADFORD,
        BROADLANDS,
        BROADMEADOWS,
        BROOKLYN,

        [Display(Name = "BROWN HILL")]
        BROWNHILL,

        BRUNSWICK,

        [Display(Name = "BRUNSWICK EAST")]
        BRUNSWICKEAST,

        [Display(Name = "BRUNSWICK WEST")]
        BRUNSWICKWEST,

        BRUTHEN,
        BUANGOR,
        BUCHAN,
        BUCKLEY,
        BUFFALO,
        BULLA,
        BULLAROOK,
        BULLEEN,
        BULLENGAROOK,

        [Display(Name = "BULN BULN")]
        BULNBULN,

        BUNBARTHA,
        BUNDALONG,
        BUNDOORA,
        BUNGAREE,
        BUNINYONG,
        BUNYIP,
        BURNLEY,

        [Display(Name = "BURNSIDE HEIGHTS")]
        BURNSIDEHEIGHTS,

        BURRUMBEET,
        BURWOOD,

        [Display(Name = "BURWOOD EAST")]
        BURWOODEAST,

        BUXTON,
        BYADUK,
        BYAWARTHA,
        CAIRNLEA,

        [Display(Name = "CALIFORNIA GULLY")]
        CALIFORNIAGULLY,

        CALIVIL,
        CAMBERWELL,
        CAMPBELLFIELD,

        [Display(Name = "CAMPBELLS BRIDGE")]
        CAMPBELLSBRIDGE,

        [Display(Name = "CAMPBELLS CREEK")]
        CAMPBELLSCREEK,

        CAMPERDOWN,
        CANIAMBO,

        [Display(Name = "CANN RIVER")]
        CANNRIVER,

        CANTERBURY,

        [Display(Name = "CAPE BRIDGEWATER")]
        CAPEBRIDGEWATER,

        [Display(Name = "CAPE CLEAR")]
        CAPECLEAR,

        [Display(Name = "CAPE PATERSON")]
        CAPEPATERSON,

        [Display(Name = "CAPE SCHANCK")]
        CAPESCHANCK,

        [Display(Name = "CAPE SCHANK")]
        CAPESCHANK,

        [Display(Name = "CAPE WOOLAMAI")]
        CAPEWOOLAMAI,

        CARAMUT,
        CARBOOR,
        CARDINIA,
        CARDROSS,
        CARISBROOK,

        [Display(Name = "CARLISLE RIVER")]
        CARLISLERIVER,

        CARLSRUSHE,
        CARLTON,

        [Display(Name = "CARNBOURNE EAST")]
        CARNBOURNEEAST,

        CARNEGIE,

        [Display(Name = "CAROLINE SPRINGS")]
        CAROLINESPRINGS,

        CARRANBALLAC,
        CARRUM,

        [Display(Name = "CARRUM DOWNS")]
        CARRUMDOWNS,

        CASHMORE,
        CASTERTON,
        CASTLEMAINE,
        CATANI,
        CATHCART,
        CAULFIELD,

        [Display(Name = "CAULFIELD EAST")]
        CAULFIELDEAST,

        [Display(Name = "CAULFIELD NORTH")]
        CAULFIELDNORTH,

        [Display(Name = "CAULFIELD SOUTH")]
        CAULFIELDSOUTH,

        CAVENDISH,
        CERES,
        CHADSTONE,
        CHARLTON,
        CHELSEA,

        [Display(Name = "CHELSEA HEIGHTS")]
        CHELSEAHEIGHTS,

        CHELTENHAM,
        CHEWTON,
        CHILTERN,

        [Display(Name = "CHIRNSIDE PARK")]
        CHIRNSIDEPARK,

        [Display(Name = "CHRISTMAS HILLS")]
        CHRISTMASHILLS,

        CHURCHILL,
        CLARENDON,
        CLARINDA,
        CLARKEFIELD,
        CLAYTON,

        [Display(Name = "CLAYTON SOUTH")]
        CLAYTONSOUTH,

        [Display(Name = "CLIFTON HILL")]
        CLIFTONHILL,

        [Display(Name = "CLIFTON SPRINGS")]
        CLIFTONSPRINGS,

        CLOVERLEA,
        CLUNES,
        CLYDE,

        [Display(Name = "CLYDE NORTH")]
        CLYDENORTH,

        CLYDEBANK,
        COBDEN,
        COBRAM,
        COBRICO,
        COBURG,

        [Display(Name = "COBURG NORTH")]
        COBURGNORTH,

        [Display(Name = "COBURG WEST")]
        COBURGWEST,

        COCKATOO,
        COHUNA,
        COLAC,
        COLBINABBIN,
        COLDSTREAM,
        COLERAINE,
        COLIGNAN,
        COLLIGNEE,
        COLLINGWOOD,
        CONGUPNA,
        CONNEWARRE,
        CONNEWIRRICOO,
        COOLAROO,
        COOMA,
        COORIEMUNGLE,

        [Display(Name = "CORA LYNNE")]
        CORALYNNE,

        CORINDHAP,
        CORINELLA,
        CORIO,

        [Display(Name = "CORONET BAY")]
        CORONETBAY,

        COROROOKE,
        CORRYONG,
        COSGROVE,
        COWES,
        COWWARR,
        CRAIGIEBURN,
        CRANBOURNE,

        [Display(Name = "CRANBOURNE EAST")]
        CRANBOURNEEAST,

        [Display(Name = "CRANBOURNE NORTH")]
        CRANBOURNENORTH,

        [Display(Name = "CRANBOURNE SOUTH")]
        CRANBOURNESOUTH,

        CREMORNE,
        CRESWICK,

        [Display(Name = "CRIB POINT")]
        CRIBPOINT,

        CROYDEN,
        CROYDON,

        [Display(Name = "CROYDON HILLS")]
        CROYDONHILLS,

        [Display(Name = "CROYDON NORTH")]
        CROYDONNORTH,

        [Display(Name = "CROYDON SOUTH")]
        CROYDONSOUTH,

        CUDGEWA,
        CULGOA,
        CULLULLERAINE,

        [Display(Name = "DAISY HILL")]
        DAISYHILL,

        DALLAS,
        DALYSTON,
        DANDENONG,

        [Display(Name = "DANDENONG NORTH")]
        DANDENONGNORTH,

        [Display(Name = "DANDENONG SOUTH")]
        DANDENONGSOUTH,

        DARLEY,
        DARNUM,
        DARTMOOR,
        DARTMOUTH,
        DAYLESFORD,
        DEAN,

        [Display(Name = "DEANS MARSH")]
        DEANSMARSH,

        [Display(Name = "DEAVON MEADOWS")]
        DEAVONMEADOWS,

        DEDERANG,

        [Display(Name = "DEER PARK")]
        DEERPARK,

        DELACOMBE,
        DELAHEY,
        DENNINGTON,
        DERGHOLM,
        DERRIMUT,
        DERRINALLUM,
        DEVENISH,
        DHURRINGILE,

        [Display(Name = "DIAMOND CREEK")]
        DIAMONDCREEK,

        DIGBY,

        [Display(Name = "DIGGERS REST")]
        DIGGERSREST,

        DIMBOOLA,
        DINGEE,

        [Display(Name = "DINGLEY VILLAGE")]
        DINGLEYVILLAGE,

        [Display(Name = "DIXONS CREEK")]
        DIXONSCREEK,

        DOCKLANDS,
        DONALD,
        DONCASTER,
        DONNYBROOK,
        DONVALE,
        DOOKIE,
        DOREEN,
        DOUGLAS,
        DOVETON,
        DROMANA,
        DROUIN,

        [Display(Name = "DROUIN WEST")]
        DROUINWEST,

        DRUMBORG,
        DRUMCONDRA,
        DRUNG,
        DRYSDALE,
        DUMBALK,

        [Display(Name = "DUMBALK NORTH")]
        DUMBALKNORTH,

        DUNKELD,
        DUNLUCE,
        DUNNSTOWN,
        DUNOLLY,
        DUNSTOWN,

        [Display(Name = "EAGLE POINT")]
        EAGLEPOINT,

        EAGLEHAWK,

        [Display(Name = "EAST DONCASTER")]
        EASTDONCASTER,

        [Display(Name = "EAST GEELONG")]
        EASTGEELONG,

        [Display(Name = "EAST IVANHOE VIC")]
        EASTIVANHOEVIC,

        [Display(Name = "EAST KEILOR")]
        EASTKEILOR,

        [Display(Name = "EAST MALVERN")]
        EASTMALVERN,

        ECHUCA,

        [Display(Name = "ECKLIN SOUTH")]
        ECKLINSOUTH,

        EDENHOPE,

        [Display(Name = "EDI UPPER")]
        EDIUPPER,

        EDITHVALE,
        EILDON,
        ELAINE,
        ELDORADO,
        ELLIMINYT,
        ELLINBANK,
        ELMHURST,
        ELMORE,
        ELPHINSTONE,
        ELSTERNWICK,
        ELTHAM,

        [Display(Name = "ELTHAM NORTH")]
        ELTHAMNORTH,

        ELWOOD,
        EMERALD,

        [Display(Name = "EMU CREEK")]
        EMUCREEK,

        [Display(Name = "ENDEAVOUR HILLS")]
        ENDEAVOURHILLS,

        ENFIELD,
        ENSAY,
        EPPING,
        EPSOM,
        ESKDALE,
        ESSENDON,
        EUMEMMERRING,
        EUROA,
        EVERTON,
        EYNESBURY,
        FAIRFIELD,
        FAIRHAVEN,
        FAWKNER,
        FERGUSON,
        FERNBANK,

        [Display(Name = "FERNTREE GULLY")]
        FERNTREEGULLY,

        [Display(Name = "FERNY CREEK")]
        FERNYCREEK,

        FINGAL,

        [Display(Name = "FISH CREEK")]
        FISHCREEK,

        FITZROY,

        [Display(Name = "FITZROY NORTH")]
        FITZROYNORTH,

        FLEMINGTON,
        FLINDERS,

        [Display(Name = "FLORA HILL")]
        FLORAHILL,

        FLOWERDALE,
        FLYNN,
        FOOTSCRAY,

        [Display(Name = "FOREST HILL")]
        FORESTHILL,

        FORREST,
        FOSTER,
        FRAMLINGHAM,

        [Display(Name = "FRAMLINGHAM EAST")]
        FRAMLINGHAMEAST,

        FRANKSTON,

        [Display(Name = "FRANKSTON NORTH")]
        FRANKSTONNORTH,

        [Display(Name = "FRANKSTON SOUTH")]
        FRANKSTONSOUTH,

        [Display(Name = "FRESHWATER CREEK")]
        FRESHWATERCREEK,

        GANNAWARRA,
        GAPSTED,
        GARFIELD,

        [Display(Name = "GARFIELD NORTH")]
        GARFIELDNORTH,

        GEELONG,

        [Display(Name = "GEELONG SOUTH")]
        GEELONGSOUTH,

        [Display(Name = "GEELONG WEST")]
        GEELONGWEST,

        GELLIBRAND,
        GEMBROOK,
        GERANGAMETE,
        GHERINGHAP,
        GIRGARRE,
        GISBORNE,

        [Display(Name = "GISBORNE SOUTH")]
        GISBORNESOUTH,

        [Display(Name = "GLADSTONE PARK")]
        GLADSTONEPARK,

        GLADYSDALE,

        [Display(Name = "GLEN ALVIE")]
        GLENALVIE,

        [Display(Name = "GLEN FORBES")]
        GLENFORBES,

        [Display(Name = "GLEN HUNTLY")]
        GLENHUNTLY,

        [Display(Name = "GLEN IRIS")]
        GLENIRIS,

        [Display(Name = "GLEN WAVERLEY")]
        GLENWAVERLEY,

        GLENALADALE,
        GLENGARRY,
        GLENLYON,
        GLENORCHY,
        GLENROWAN,
        GLENROY,
        GLENTHOMPSON,
        GNARWARRE,
        GOBUR,

        [Display(Name = "GOLDEN BEACH")]
        GOLDENBEACH,

        [Display(Name = "GOLDEN SQUARE")]
        GOLDENSQUARE,

        GOORAMBAT,
        GOORNONG,
        GORDON,
        GORMANDALE,
        GOROKE,
        GOWANBRAE,
        GRANTVILLE,

        [Display(Name = "GREAT WESTERN")]
        GREATWESTERN,

        GREENDALE,
        GREENSBOROUGH,
        GREENVALE,
        GRENVILLE,
        GRETA,

        [Display(Name = "GRETA SOUTH")]
        GRETASOUTH,

        GROVEDALE,
        GRUYERE,
        GUILDFORD,
        GUNBOWER,
        GUNDOWRING,

        [Display(Name = "GUYS HILL")]
        GUYSHILL,

        HADDON,
        HADFIELD,
        HALLAM,
        HALLORA,

        [Display(Name = "HALLS GAP")]
        HALLSGAP,

        HAMILTON,

        [Display(Name = "HAMLYN HEIGHTS")]
        HAMLYNHEIGHTS,

        HAMPTON,

        [Display(Name = "HAMPTON EAST")]
        HAMPTONEAST,

        [Display(Name = "HAMPTON PARK")]
        HAMPTONPARK,

        HANSNVILLE,
        HARCOURT,
        HARKAWAY,
        HARRIETVILLE,
        HARROW,
        HASTINGS,
        HAVEN,
        HAWKESDALE,
        HAWTHORN,

        [Display(Name = "HAWTHORN EAST")]
        HAWTHORNEAST,

        HEALESVILLE,
        HEATHCOTE,
        HEATHERTON,
        HEATHMERE,
        HEATHMONT,
        HEIDELBERG,

        [Display(Name = "HEIDELBERG HEIGHTS")]
        HEIDELBERGHEIGHTS,

        [Display(Name = "HEPBURN SPRINGS ")]
        HEPBURNSPRINGS,

        [Display(Name = "HERNE HILL")]
        HERNEHILL,

        HEXHAM,
        HEYFIELD,
        HEYWOOD,
        HIGHETT,
        HIGHTON,
        HILLSIDE,

        [Display(Name = "HMAS CERBERUS")]
        HMASCERBERUS,

        [Display(Name = "HODDLES CREEK")]
        HODDLESCREEK,

        HOPETOUN,

        [Display(Name = "HOPPERS CROSSING")]
        HOPPERSCROSSING,

        HORSHAM,
        HUMEVALE,
        HUNTINGDALE,
        HUNTLY,

        [Display(Name = "HUNTLY NORTH")]
        HUNTLYNORTH,

        HURSTBRIDGE,

        [Display(Name = "INDENTED HEAD")]
        INDENTEDHEAD,

        INGLEWOOD,
        INVERGORDON,
        INVERLEIGH,
        INVERLOCH,
        INVERMAY,
        IRONBARK,
        IRREWARRA,
        IRREWILLIPE,
        IRYMPLE,
        IVANHOE,

        [Display(Name = "IVANHOE EAST")]
        IVANHOEEAST,

        JACANA,

        [Display(Name = "JAN JUC")]
        JANJUC,

        JARKLIN,
        JEPARIT,
        JINDIVICK,
        JOHANNA,

        [Display(Name = "JUNCTION VILLAGE")]
        JUNCTIONVILLAGE,

        JUNORTOUN,
        KAARIMBA,
        KALORAMA,

        [Display(Name = "KANGAROO FLAT")]
        KANGAROOFLAT,

        [Display(Name = "KANGAROO GROUND")]
        KANGAROOGROUND,

        KANIVA,
        KARRAMOMUS,
        KATAMATITE,

        [Display(Name = "KATANDRA WEST")]
        KATANDRAWEST,

        KATUNGA,
        KAWARREN,
        KEALBA,
        KEILOR,

        [Display(Name = "KEILOR DOWNS")]
        KEILORDOWNS,

        [Display(Name = "KEILOR EAST")]
        KEILOREAST,

        [Display(Name = "KEILOR PARK")]
        KEILORPARK,

        KELBA,

        [Display(Name = "KENNETT RIVER")]
        KENNETTRIVER,

        KENNINGTON,

        [Display(Name = "KEON PARK")]
        KEONPARK,

        KERANG,
        KERNOT,
        KERRRIMUIR,
        KEW,

        [Display(Name = "KEW EAST")]
        KEWEAST,

        KEYSBOROUGH,
        KIALLA,

        [Display(Name = "KIALLA WEST")]
        KIALLAWEST,

        KIEWA,
        KILLARA,
        KILLARNEY,
        KILLAWARRA,
        KILMANY,
        KILMORE,
        

        [Display(Name = "KILMORE EAST")]
        KILMOREEAST,

        KILSYTH,
        KIMBOLTON,
        KINGLAKE,
        

        [Display(Name = "KINGLAKE WEST")]
        KINGLAKEWEST,

        KINGOWER,
        KINGSBURY,
        KINGSTON,
        KNOWSLEY,
        KNOXFIELD,
        KONGWAK,
        

        [Display(Name = "KOO WEE RUP")]
        KOOWEERUP,

        KOONDROOK,
        KOONOOMOO,
        KOONWARRA,
        KOORLONG,
        KOOYONG,
        KORIOT,
        

        [Display(Name = "KORONG VALE")]
        KORONGVALE,

        KORUMBURRA,
        KORWEINGUBOORA,
        KOYUGA,
        

        [Display(Name = "KY VALLEY")]
        KYVALLEY,

        KYABRAM,
        KYBRAM,
        KYNETON,
        KYOUGA,
    }
}