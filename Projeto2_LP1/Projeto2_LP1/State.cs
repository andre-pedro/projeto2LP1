namespace Projeto2_LP1
{
    /// <summary>
    /// Class criada a partir de lista para
    /// poder ser efectuada a grid de jogo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class State<T>
    {
        private T[] items;

        public State()
        {
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        /// <summary>
        /// Método do qual permite aumentar o
        /// nosso array.
        /// </summary>
        /// <param name="newItem"></param>
        public void Add(T newItem)
        {

            T[] newItems = new T[items.Length + 1];

            for (int index = 0; index < items.Length; index++)
            {
                newItems[index] = items[index];
            }

            newItems[newItems.Length - 1] = newItem;


            items = newItems;
        }

        /// <summary>
        /// Método que irá retornar o tamanho 
        /// actual do nossa lista.
        /// </summary>
        public int Size
        {
            get
            {
                return items.Length;
            }
        }
    }
}

