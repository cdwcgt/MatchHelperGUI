using MatchHelperGUI.Game.Chat;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Audio;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Screens;
using osuTK;

namespace MatchHelperGUI.Game
{
    public partial class MainScreen : Screen
    {
        private ChatDisplay chat;
        private SpriteText infoText;

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChild = new Container
            {
                RelativeSizeAxes = Axes.Both,
                Margin = new MarginPadding(10),
                Children = new Drawable[]
                {
                    infoText = new SpriteText { Text = "未连接", Font = OsuFont.GetFont().With(size: 20) },
                    new Container
                    {
                        Padding = new MarginPadding
                        {
                            Right = 200
                        },
                        RelativeSizeAxes = Axes.Both,
                        Children = new Drawable[]
                        {
                            chat = new ChatDisplay
                            {
                                RelativeSizeAxes = Axes.Both,
                            },
                        }
                    },
                    new Container
                    {
                        Anchor = Anchor.TopRight,
                        Origin = Anchor.TopRight,
                        Width = 200,
                        RelativeSizeAxes = Axes.Y,
                        Children = new Drawable[]
                        {
                            new Box
                            {
                                RelativeSizeAxes = Axes.Both,
                                Colour = Colour4.Gray,
                            }
                        }
                    }
                }
            };
            chat.AddMessage(new Message("PercyDan222222222", "PercyDan"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
        }
    }
}
