using Forest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<Forest.Data.Music_Category> GetMusicCategories();
        //   IList<Forest.Data.Music_Recording> GetMusicRecordings(string genre);
        IList<Forest.Data.BEANS.MusicBEAN> GetMusicRecordings(int genre);
        Forest.Data.Music_Recording GetMusicRecording(int id);
        Music_Category GetMusicCategory(int id);
        void EditMusicRecording(Music_Recording recording);
        void EditMusicGenre(Music_Category category);

        void AddMusicRecording(Music_Recording recording);

        void AddMusicGenre(Music_Category category);
        void DeleteMusicRecording(Music_Recording recording);

        void DeleteMusicGenre(Music_Category category);
    }
}
