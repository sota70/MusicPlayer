using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer.Interface;

namespace MusicPlayer.Data
{
    class DataManager
    {
        private static List<IMusic> DataBase = new List<IMusic>();

        public static void SetData(IMusic MusicData)
        {
            DataBase.Add(MusicData);
        }

        public static IMusicReadable GetData(IMusic targetData)
        {
            IMusicReadable MusicData = null; 
            // 取得したいデータ(targetData)と一致したデータをDataBaseの中から取り出す
            foreach (IMusic data in DataBase)
            {
                bool isDataMatch = data.Equals(targetData);
                if (!isDataMatch) continue;
                MusicData        = data;
            }
            return MusicData;
        }

        public static IMusicReadable GetData(string targetData, string Artist)
        {
            IMusicReadable MusicData = null;
            // 取得したいデータ(targetData)と一致したデータをDataBaseの中から取り出す
            foreach (IMusic data in DataBase)
            {
                bool isDataMatch = ((IMusicReadable)data).MusicName.Equals(targetData) && ((IMusicReadable)data).Artist.Equals(Artist);
                if (!isDataMatch) continue;
                MusicData        = data;
            }
            return MusicData;
        }

        public static void SwitchDataPosition(IMusic firstData, IMusic secondData)
        {
            int firstDataPosition        = DataIndexInList(firstData);
            int secondDataPosition       = DataIndexInList(secondData);
            DataBase[firstDataPosition]  = secondData;
            DataBase[secondDataPosition] = firstData;
        }

        private static bool DataExists(IMusic MusicData)
        {
            bool dataExists = DataBase.Contains(MusicData);
            if (dataExists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int DataIndexInList(IMusic MusicData)
        {
            if (!DataExists(MusicData)) return 0;
            int index = DataBase.IndexOf(MusicData);
            return index;
        }
    }
}
