using Model;
using Repository.VirtualDataBase;
using System.Net.Http.Headers;

namespace Repository
{
    public class RoomRepository : BaseRepository<Room>
    {
        public Room Create(Room room)
        {
            room.Id = GetNextId();
            MyData.Rooms.Add(room);
            return room;
        }

        public void Delete(Room room)
        {
            MyData.Rooms.Remove(room);
        }

        public void Update(Room room)
        {
            var _room = GetById(room.Id);
            _room.RoomType = room.RoomType;
            _room.RoomNumber = room.RoomNumber;
        }

        public Room GetById(int id)
        {
            var room = MyData.Rooms.FirstOrDefault(x => x.Id == id);
            
            if (room is null) return null!;
            
            return room;
        }
    }
}
