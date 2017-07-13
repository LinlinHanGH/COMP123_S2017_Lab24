/*
 * Name: Linlin Han
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * Version: 0.2 - Added constructors in SuperVillain class
 */

namespace COMP123_S2017_Lab24
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain:SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}
