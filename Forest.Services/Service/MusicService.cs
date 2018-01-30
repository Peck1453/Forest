using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data;
using Forest.Data.DAO;
using Forest.Data.IDAO;

namespace Forest.Services.Service
{
    public class MusicService : Forest.Services.IService.IMusicService

    {
        private IMusicDAO _musicDAO;

        public MusicService()
        {
            _musicDAO = new MusicDAO();

        }

        public IList<Music_Category> GetMusicCategories()
        {
            return _musicDAO.GetMusicCategories();

        }

        //public IList<Music_Recording> GetMusicRecordings(string genre)
        //{
        //    return _musicDAO.GetMusicRecordings(genre);
        //}
        public IList<Forest.Data.BEANS.MusicBEAN> GetMusicRecordings(int genre)
        {
            return _musicDAO.GetMusicRecordings(genre);
        }

        public Music_Recording GetMusicRecording(int id)
        {
            return _musicDAO.GetMusicRecording(id);
        }

        public void EditMusicRecording(Music_Recording recording)
        {
            _musicDAO.EditMusicRecording(recording);
        }

        public Music_Category GetMusicCategory(int id)
        {
            return _musicDAO.GetMusicCategory(id);

        }

        public void EditMusicGenre(Music_Category category)
        {
            _musicDAO.EditMusicGenre(category);
        }


        public void AddMusicRecording(Music_Recording recording)
        {

            _musicDAO.AddMusicRecording(recording);

        }

        public void AddMusicGenre(Music_Category category)
        {

            _musicDAO.AddMusicGenre(category);

        }

        public void DeleteMusicRecording(Music_Recording recording)
        {
            _musicDAO.DeleteMusicRecording(recording);


        }

        public void DeleteMusicGenre(Music_Category category)
        {

            _musicDAO.DeleteMusicGenre(category);

        }
    }
}

