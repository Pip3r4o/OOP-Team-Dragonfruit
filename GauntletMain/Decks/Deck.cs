using System.Collections.Generic;
using TrialOfFortune.Utilities;
using TrialOfFortune.Classes;

namespace TrialOfFortune.Decks
{
    abstract class Deck<T> : GameObject, IShuffle
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
                return listOfCards[this.normalizeIndex(i)];
            }
            set
            {
                listOfCards[this.normalizeIndex(i)] = value;
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

        private int normalizeIndex(int i)
        {
            // To make it cyclic:
            while (i < 0)
            {
                i += this.Count();
            }
            while (i >= this.Count())
            {
                i -= this.Count();
            }

            return i;
        }
        #endregion
    }
}
