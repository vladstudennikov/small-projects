using System;

namespace Lab_1
{
    public abstract class DBModel
    {
        public Human[] list = new Human[30];
        public string path;

        public DBModel(string path)
        {
            this.path = path;
        }

        public abstract void getDB();


        public int getFilledPositions()
        {
            int s = 0;
            for (int i = 0; i < 30; i++)
            {
                if (list[i] != null)
                {
                    ++s;
                }
                else
                {
                    return s;
                }
            }
            return list.Length;
        }

        public bool IsInTheDB(Human a)
        {
            if (this.getFilledPositions() == 0)
            {
                this.getDB();
            }

            for (int i = 0; i < this.getFilledPositions(); i++)
            {
                if ((this.list[i].PassportID).Equals(a.PassportID))
                {
                    return true;
                }
            }
            return false;
        }

        public Human lastNameSearch(string lastName)
        {
            if (this.getFilledPositions() == 0)
            {
                this.getDB();
            }

            int i = 0;
            while (list[i] != null)
            {
                if (list[i].LastName.Equals(lastName))
                {
                    return list[i];
                }
                ++i;
            }
            return null;
        }

        public Human passportIDSearch(string id)
        {
            if (this.getFilledPositions() == 0)
            {
                this.getDB();
            }

            int i = 0;
            while (list[i] != null)
            {
                if (list[i].PassportID.Equals(id))
                {
                    return list[i];
                }
                ++i;
            }
            return null;
        }
    }
}