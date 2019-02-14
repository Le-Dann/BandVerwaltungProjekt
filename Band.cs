using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wndNewBand
{
        /// <summary>
        /// Band Class
        /// </summary>
        /// <remarks>Class stores and displays band info. and rating</remarks>
        public class Band 
        {
        #region Properties
        /// <summary>
        /// Number of band albums
        /// </summary>
        private int _anzahlAlben;

        public int AnzahlAlben
        {
            get { return _anzahlAlben; }
            set {

                if (value >= 0)
                {
                    _anzahlAlben = value;
                }
                else 
                {

                    throw new NegativeNumberExcpetion("Negative number cannot be used for the number of albums");
                }
            }
        }

        /// <summary>
        /// Number of members in band
        /// </summary>
        private int _anzahlMitglieder;

            public int AnzahlMitglieder
            {
                get { return _anzahlMitglieder; }
                set {
                if (value >= 0)
                {
                    _anzahlMitglieder = value;
                }
                else
                {

                    throw new NegativeNumberExcpetion("Negative number cannot be used for the number of band members");
                }

            }
            }

            /// <summary>
            /// Name of the band
            /// </summary>
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

        /// <summary>
        /// Number of band objects created
        /// </summary>
        private static int  _objektZaehler = 0;

        public int Objektzaehler
        {
            get { return _objektZaehler; }
        }

        private string _rating;

        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// basis constructor
        /// </summary>
        public Band() : this("", 0, 0) { }

            /// <summary>
            /// second constructor
            /// </summary>
            /// <param name="bandName"> name of the band</param>
            public Band(string bandName) : this(bandName, 0, 0) { }

            /// <summary>
            /// third constructor
            /// </summary>
            /// <param name="bandName">name of the band</param>
            /// <param name="stilRichtung">genre of the band</param>
            /// <param name="anzahlMitglieder">number of band members</param>
            public Band(string bandName, int anzahlMitglieder, int anzAlben)
            {
                Name = bandName;
                AnzahlMitglieder = anzahlMitglieder;
                AnzahlAlben = anzAlben;
                Band._objektZaehler ++;
                Rating = GetRating();

        }
            #endregion

            #region Methods
            /// <summary>
            /// Gets information on the band
            /// </summary>
            /// <returns> band information</returns>
            public string GetInfo()
            {
                string info = $"Band= {Name}, Anzahl Mitglieder= {AnzahlMitglieder}, AnzahlAlben= {AnzahlAlben}";
                return info;
            }

            /// <summary>
            /// Gets the band's album rating
            /// </summary>
            /// <returns>number of stars which represents the rating</returns>
            public string GetRating()
            {
                string rating = "";
                if (AnzahlAlben >= 20)
                {
                    rating = "****";
                }
                else
                {
                    if (AnzahlAlben >= 10)
                    {
                        rating = "***";
                    }
                    else
                    {
                        if (AnzahlAlben >= 5)
                        {
                            rating = "**";
                        }
                        else
                        {
                            if (AnzahlAlben >= 0)
                            {
                                rating = "*";
                            }
                            else
                            {
                                rating = "No Rating";
                            }
                        }
                    }

                }
                 Rating = rating;
                return rating;
            }
            #endregion
        }
}
