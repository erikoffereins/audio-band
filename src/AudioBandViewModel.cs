﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CSDeskBand.Annotations;

namespace AudioBand
{
    public class AudioBandViewModel : INotifyPropertyChanged
    {
        private bool _isPlaying;

        public bool IsPlaying
        {
            get => _isPlaying;
            set
            {
                if (value == _isPlaying) return;
                _isPlaying = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}