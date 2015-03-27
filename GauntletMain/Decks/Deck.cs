﻿using System.Collections.Generic;
using GauntletMain.Utilities;

namespace GauntletMain.Classes
{
    class Deck<T>
    {
        protected List<T> listOfCards = new List<T>();

        #region Fields
        public List<T> ListOfCards
        {
            get
            {
                return this.listOfCards;
            }
        }
        #endregion

        public T this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets 
                // the corresponding element from the internal array. 
                return listOfCards[i];
            }
            set
            {
                listOfCards[i] = value;
            }
        }

        public int Count()
        {
            return ListOfCards.Count;
        }

        #region Methods
        public void Shuffle()
        {
            listOfCards.Shuffle<T>();
        }
        #endregion
    }
}