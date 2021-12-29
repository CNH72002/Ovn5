using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public interface IHandler<T>
    {
        //Property for count
        int Count { get; }

        //For adding object to 
        bool Add(T type);

        // Method to change an object at an index 
        bool ChangeAt(T type, int index);

        //Method to check an index validity
        bool CheckIndexF(int index);

        void DeleteAll();

        //Method to delete an object at a certain position in a list
        bool DeleteAt(int index);

    }
}
