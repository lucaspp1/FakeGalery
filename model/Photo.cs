
using System;

namespace galery.model
{
    public class Photo
    {
    
        public int id {get; set; }
        public DateTime postDate {get; set; }
        public string url {get; set; }
        public string description {get; set; }
        public bool allowComments {get; set; }
        public int likes {get; set; }
        public int comments {get; set; }
        public int userId {get; set; }
        public Photo(int id, DateTime postDate, string url, string description, bool allowComments, int likes, int comments, int userId){
            this.id = id;
            this.postDate = postDate;
            this.url = url;
            this.description = description;
            this.allowComments = allowComments;
            this.likes = likes;
            this.comments = comments;
            this.userId = userId;
        }
    }
}
