using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;
using MYWeb_W1.Models;
using MYWeb_W1.Services;

public class LineService : ILineService
{
    private readonly MeMeServicess _meMeServicess;

    public LineService()
    {
        _meMeServicess = new MeMeServicess();
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        if (message == ("推薦梗圖"))
        {
            List<MeMeModels> data = await _meMeServicess.List(11);
            int index = (new Random()).Next(0, data.Count);
            
            return new List<ISendMessage>
            {
                new ImageMessage(data[index].src, data[index].src, null),
            };
        }
        
        if (message == ("交通梗圖"))
        {
            List<MeMeModels> data = await _meMeServicess.List(3350);
            int index = (new Random()).Next(0, data.Count);
            
            return new List<ISendMessage>
            {
                new ImageMessage(data[index].src, data[index].src, null),
            };
        }
        
        if (message == ("時事梗圖"))
        {
            List<MeMeModels> data = await _meMeServicess.List(35);
            int index = (new Random()).Next(0, data.Count);
            
            return new List<ISendMessage>
            {
                new ImageMessage(data[index].src, data[index].src, null),
            };
        }
        
        if (message == ("VTUBER梗圖"))
        {
            List<MeMeModels> data = await _meMeServicess.List(319);
            int index = (new Random()).Next(0, data.Count);
            
            return new List<ISendMessage>
            {
                new ImageMessage(data[index].src, data[index].src, null),
            };
        }
        
        if (message == ("18+梗圖"))
        {
            List<MeMeModels> data = await _meMeServicess.List(55);
            int index = (new Random()).Next(0, data.Count);
            
            return new List<ISendMessage>
            {
                new ImageMessage(data[index].src, data[index].src, null),
            };
        }

        /*if (message.Contains(""))
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        }*/

        /* if (message == "梗圖貓")
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "https://memeprod.ap-south-1.linodeobjects.com/user-template/65d37cb62a8b3b73ca8a214460312fcc.png",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/03f01617946e73cbcb2259e47a4a69ca.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/7818ccbe151d3f3b456c2cc4f6f67a5d.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/19853e64694b66152c44077e172f67b1.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/9c25048e77b4d0b0b9eb617d1ff5e3e0.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/cb96c630886a29cd1b56c5d4b0ca4e80.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/fac52984bbda3e6a94502dd9e6ad3165.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/acf932b6af403635a9b340b939a9050a.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/b848719c6ac1c31845eccfd455d9d477.jpg",
                "https://memeprod.ap-south-1.linodeobjects.com/user-template-thumbnail/3921a3c25ef391c860dd0fe29c1c627d.jpg",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        }

        if (message == ("梗圖瑟瑟"))
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1660109954183.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1660154123990.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1664085695736.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1685490023344.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1690361305373.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1702452559714.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1711717840821.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1712185211501.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1712460406309.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1658648230414.jpg",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        }

        if (message == ("梗圖Minecraft"))
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1653471147773.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1651559432348.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1644655220716.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1644586824788.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1644324780510.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1637489142161.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1636277367704.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1634731569184.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1633255207821.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1633150574925.jpg",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        }

        if (message == "推薦梗圖")
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1714638857118.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1714001627791.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1713877267429.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1713605845579.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1672601089631.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1661567701802.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1660578558172.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1658108404882.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1644208323049.jpg",
                "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1641741067640.jpg",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        }

        if (message.Contains(""))
        {
            string[] imageUrl = new string[] //擺圖片
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imageUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imageUrl[index], imageUrl[index], null),
            };
        } */


        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a text event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    } 

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,
        string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,
        string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,
        string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,
        string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,
        string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}