using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        IList<Music_Category> GetMusicCategories();
        IList<Music_Recording> GetMusicRecordings(string genre);
        Music_Recording GetMusicRecording(int id);
        void EditMusicRecording(Music_Recording recording);
    }
}
