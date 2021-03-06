﻿using System.Drawing;
using AudioBand.Extensions;
using AudioBand.Models;

namespace AudioBand.ViewModels
{
    /// <summary>
    /// View model for the album art popup.
    /// </summary>
    internal class AlbumArtPopupVM : ViewModelBase<AlbumArtPopup>
    {
        private readonly Track _track;

        public AlbumArtPopupVM(AlbumArtPopup model, Track track)
            : base(model)
        {
            _track = track;
            SetupModelBindings(_track);
        }

        [PropertyChangeBinding(nameof(AlbumArtPopup.IsVisible))]
        public bool IsVisible
        {
            get => Model.IsVisible;
            set => SetProperty(nameof(Model.IsVisible), value);
        }

        [PropertyChangeBinding(nameof(AlbumArtPopup.Width))]
        [AlsoNotify(nameof(Size))]
        public int Width
        {
            get => Model.Width;
            set => SetProperty(nameof(Model.Width), value);
        }

        [PropertyChangeBinding(nameof(AlbumArtPopup.Height))]
        [AlsoNotify(nameof(Size))]
        public int Height
        {
            get => Model.Height;
            set => SetProperty(nameof(Model.Height), value);
        }

        [PropertyChangeBinding(nameof(AlbumArtPopup.XPosition))]
        public int XPosition
        {
            get => Model.XPosition;
            set => SetProperty(nameof(Model.XPosition), value);
        }

        [PropertyChangeBinding(nameof(AlbumArtPopup.Margin))]
        public int Margin
        {
            get => Model.Margin;
            set => SetProperty(nameof(Model.Margin), value);
        }

        [PropertyChangeBinding(nameof(Track.AlbumArt))]
        public Image AlbumArt => _track.AlbumArt?.Resize(Width, Height);

        /// <summary>
        /// Gets the size of the popup.
        /// </summary>
        /// <remarks>This property exists so the designer can bind to it.</remarks>
        public Size Size => new Size(Width, Height);
    }
}
