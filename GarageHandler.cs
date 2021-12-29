using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public class GarageHandler<T> : IHandler<T>
    {


        private List<T> m_List;

        public GarageHandler()
        {
            m_List = new List<T>();
        }



        //Implementation of the count property
        public int Count
        {

            get
            {
                if (m_List != null)
                {
                    return m_List.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        


        //Implementation of Add method
        public bool Add(T type)   // Add T type
        {
            bool ok = false;
            if (type != null)
            {
                m_List.Add(type);   //Add the object to the m_list
                ok = true;
            }
            return ok;
        }




        //Implementation of DeleteAt method
        public bool DeleteAt(int index)
        {
            bool ok = false;

            if (CheckIndexF(index))
            {
                m_List[index] = default;
                ok = true;
            }

            return ok;
        }

        //Method to delete all in a list
        public void DeleteAll()
        {
            m_List.Clear();
        }






        //Implementation of ChangeAt method
        public bool ChangeAt(T type, int index)
        {
            bool ok = false;

            if ((type != null) && CheckIndexF(index))
            {
                m_List[index] = type;
                ok = true;
            }

            return ok;

        }


        //Method to Check index validity
        public bool CheckIndexF(int index)
        {
            return (m_List != null) & (index < m_List.Count) & (index >= 0);
        }





        /// <summary>
        /// 
        //This method  enables the program to get an  object at a particular index.
        /// </summary>
        public T GetAt(int index)
        {
            if (CheckIndexF(index))
            {
                return m_List[index];
            }
            else
            {
                return default;
            }
        }




}   }
