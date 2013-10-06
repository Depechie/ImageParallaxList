using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ImageParallaxList.Resources;

namespace ImageParallaxList.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { ID = "0", Image = "/Assets/image1.jpg", LineOne = "runtime one", LineTwo = "Maecenas praesent accumsan bibendum", Title = "Hoewel Spanje twee medailles pakte op het WK heerst er vooral ontgoocheling. De Spanjaarden moesten tevreden zijn met de tweede en derde plaats.", Body = "Met twee medailles kon Spanje terugblikken op een geslaagd WK. Toch was iedereen ontevreden bij de Spanjaarden. Bondscoach Javier Minguez was vooral boos op Alejandro Valverde. Hij vond dat de Murciaan had moeten meespringen met Rui Costa. Joaquim Rodriguez verdiende het goud, vertelde Minguez aan de Spaanse media. Het frustreert me dan ook enorm dat we hier vrede moeten nemen met de tweede en derde plaats. Joaquim reed erg goed, maar Alejandro maakte een grote fout, oordeelde de bondscoach. Als Valverde was meegesprongen met Costa, dan was hij nu wereldkampioen. Hij had moeten reageren op iedere beweging. Met twee medailles kunnen we misschien feesten, maar door deze fout zijn we geen wereldkampioen geworden. Valverde zelf liet weten dat hij de benen niet had om met de Portugees mee te springen. Dankzij zijn bronzen medaille schrijft hij wel geschiedenis. Hij is de eerste renner in de geschiedenis die tijdens vijf WK's op het podium eindigde. Eerder pakte hij al tweemaal zilver (2002, 2005) en brons (2006, 2012)" });
            this.Items.Add(new ItemViewModel() { ID = "1", Image = "/Assets/image2.jpg", LineOne = "runtime two", LineTwo = "Dictumst eleifend facilisi faucibus", Title = "Meer nog dan de verrassende winnaar waren de weersomstandigheden het gespreksonderwerp na het WK wielrennen in Firenze. De Belgen spuwen hun gal.", Body = "Nieuw asfalt en hemelsluizen die zich openen, het is een dodelijke combinatie. Dat is zondag in Firenze nog maar eens bewezen. Gelukkig niet letterlijk. De glijpartijen volgden elkaar wel in sneltempo op. Het zorgde voor een pak irritaties in het peloton. Ook bij onze landgenoten. In het tennis of het voetbal hadden ze deze wedstrijd allang afgelast, merkte Jan Bakelants fijntjes op in Het Nieuwsblad. De kersverse renner van Omega Pharma-Quick Step ging zelf tegen de vlakte. In andere koersen kan je vallen omdat je een fout maakt, maar hier was het Russische roulette. Het moet eerst eens serieus foutlopen zeker? Greg Van Avermaet kwam er vanaf zonder tuimelpertes, maar de Belgische wisselkopman is daarom niet minder ontzet. In mijn hele carrière heb ik nog nooit zo'n gevaarlijke koers gereden. Mochten ze mij vragen om volgende week in dezelfde omstandigheden opnieuw dit WK te rijden, ik zou weigeren. Het was er ver over. Bjorn Leukemans ging twee keer tegen de vlakte. De voorlopige werkloze renner voor 2014 stelde vast dat zijn remblokken pas na een paar seconden dienst deden. Als het een eerste keer regent op nieuwe asfalt, dan wordt het levensgevaarlijk. Nooit gedacht dat ik liever bergop dan bergaf zou rijden." });
            this.Items.Add(new ItemViewModel() { ID = "2", Image="/Assets/image3.jpg", LineOne = "runtime three", LineTwo = "Habitant inceptos interdum lobortis", Title = "Rui Costa is de eerste Portugese wereldkampioen wielrennen op de weg. Ik ben bijzonder trots. Ik droom allang van de regenboogtrui, zegt de opvolger van Philippe Gilbert.", Body = "Na 272,26 kilometer tussen Lucca en Firenze versloeg de renner van Movistar de Spanjaard Joaquim Rodriguez na een sprint. Het was een erg zware wedstrijd, verklaarde Costa. Italië controleerde de rit, maar het slechte weer en de valpartijen hebben alles overhoopgehaald. Op het einde wou ik energie sparen en dacht ik enkel aan de belangrijkste sprint uit mijn leven. Ik hoopte dat mijn benen me niet in de steek zouden laten. In de laatste kilometers was de wedstrijdsituatie erg complex, met twee Spaanse renners in de kopgroep. Ik verwachtte niet dat ik zou winnen, maar uiteindelijk heb ik Rodriguez toch nog ingehaald. Ik voelde een enorme blijdschap na mijn zege, zei de Portugees, die op het podium zijn tranen de vrije loop liet. Ik ben bijzonder trots. Ik droom allang van de regenboogtrui en realiseer me nog niet dat ik ze een jaar lang zal dragen." });
            this.Items.Add(new ItemViewModel() { ID = "3", Image = "/Assets/image4.jpg", LineOne = "runtime one", LineTwo = "Maecenas praesent accumsan bibendum", Title = "Philippe Gilbert staat zijn regenboogtrui zonder morren af aan Rui Costa. Toen de echte klimmers aanvielen, was het voorbij.", Body = "Een uitgebluste Gilbert finishte uiteindelijk als negende in de sprint van de achtervolgers. Toen de klimmers bij de laatste lange beklimming aan hun offensief begonnen, kon ik niet mee, verklaarde de Belgische kopman. Ik wist meteen dat de beslissing gevallen was, want twee Spanjaarden en twee Italianen laten zich niet meer terugpakken. Tot de Fiesole liep alles perfect, vertelde Phil. Ik had de andere jongens van de ploeg gevraagd om tempo te rijden zodat er geen ontsnappingen zouden komen. Maar toen de echte klimmers op hun pedalen gingen staan, was het voorbij. Op het einde was ik zo vermoeid dat ik zelfs niet meer uit het zadel kon komen om te spurten en dat ik tevreden moest zijn met de negende plaats. Ik heb alles gegeven, de ploeg heeft goed gewerkt, maar dit is de wet van de sport. We hebben ons als ploeg niets te verwijten, wist bondscoach Carlo Bomans. En dat Philippe niet gewonnen heeft, heeft te maken met het feit dat we op een parcours voor specialisten gereden hebben. Niet alleen Phil kwam tekort. Ook Peter Sagan en Fabian Cancellara konden niet volgen. Maar ik ben wel blij met de overwinning van Rui Costa. De Spanjaarden hebben geen duw gegeven toen er gewerkt moest worden. Ik gunde hen de zege echt niet, Costa met amper twee landgenoten bij zich des te meer, aldus Bomans. Ook schaduwkopman Jan Bakelants had een zware dag. Een ontgoocheling, want te veel pech gehad, zo vatte Bakelants zijn WK samen. Toen we aan de plaatselijke ronden in Firenze begonnen, heb ik twee ronden moeten achtervolgen, stelde Bakelants, die als 57ste finishte. Eerst nadat ik kledij afgegeven had, daarna nadat ik ten val gekomen was. Die val zelf was niet zo erg, maar mijn schoenplaatje was kapot en ik kon ook met mijn fiets niet meer verder. De auto van de Belgische ploeg zat zo ver achteraan dat ik veel tijd verloren heb. De krachten die ik toen verspeeld heb, kwam ik tekort in de finale. Ik heb aan Philippe gezegd dat ik de slotronde niet meer zou aankunnen. Dit was de zwaarste koers die ik ooit gereden heb, beaamde Serge Pauwels, die als helper op de 29ste plaats eindigde. Niet alleen fysiek gezien de erbarmelijke omstandigheden en de beklimmingen, maar ook mentaal omdat je meer dan zeven uur geconcentreerd moest blijven. De miserie begon al in de eerste plaatselijke ronde, vervolgde Pauwels. Net als Bakelants verzeilde ik heel ver achteraan ten gevolge van valpartijen in het peloton. Maar we bleven geconcentreerd en konden terugkeren. Daarna heb ik eigenlijk meer kunnen doen dan ik zelf verwacht had." });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}