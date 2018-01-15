using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Portal.ViewModels
{
    public class GridViewModel : Grid
    {
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create<GridViewModel, object>(p => p.CommandParameter, null);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create<GridViewModel, ICommand>(p => p.Command, null);
        private int _maxColumns = 2;
        private float _tileHeight = 100;

        public GridViewModel()
        {
            for (var i = 0; i < MaxColumns; i++)
            {
                ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        public Type ItemTemplate { get; set; }

        public int MaxColumns
        {
            get { return _maxColumns; }
            set { _maxColumns = value; }
        }

        public float TileHeight
        {
            get { return _tileHeight; }
            set { _tileHeight = value; }
        }

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public async Task BuildTiles<T>(IEnumerable<T> tiles)
        {
            // Wipe out the previous row definitions if they're there.
            if (RowDefinitions.Any())
            {
                RowDefinitions.Clear();
            }
            var enumerable = tiles as IList<T> ?? tiles.ToList();
            var numberOfRows = Math.Ceiling(enumerable.Count / (float)MaxColumns);
            for (var i = 0; i < numberOfRows; i++)
            {
                RowDefinitions.Add(new RowDefinition { Height = TileHeight });
            }

            for (var index = 0; index < enumerable.Count; index++)
            {
                var column = index % MaxColumns;
                var row = (int)Math.Floor(index / (float)MaxColumns);

                var tile = await BuildTile(enumerable[index]);

                Children.Add(tile, column, row);
            }
        }

        private async Task<Layout> BuildTile(object item1)
        {
            return await Task.Run(() =>
            {
                var buildTile = (Layout)Activator.CreateInstance(ItemTemplate, item1);
                var tapGestureRecognizer = new TapGestureRecognizer
                {
                    Command = Command,
                    CommandParameter = item1
                };

                buildTile.GestureRecognizers.Add(tapGestureRecognizer);
                return buildTile;
            });

        }
    }
}
