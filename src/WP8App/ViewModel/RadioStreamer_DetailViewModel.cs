// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of RadioStreamer_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class RadioStreamer_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IRadioStreamer_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.RadioStreamer_Streamer _radioStreamer_Streamer;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioStreamer_DetailViewModel" /> class.
        /// </summary>
        /// <param name="radioStreamer_Streamer">The Radio Streamer_ Streamer.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public RadioStreamer_DetailViewModel(Repositories.RadioStreamer_Streamer radioStreamer_Streamer, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_radioStreamer_Streamer = radioStreamer_Streamer;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.StreamerSchema _currentStreamerSchema;

        /// <summary>
        /// CurrentStreamerSchema property.
        /// </summary>		
        public Entities.StreamerSchema CurrentStreamerSchema
        {
            get
            {
				return _currentStreamerSchema;
            }
            set
            {
                SetProperty(ref _currentStreamerSchema, value);
            }
        }
	
		private bool _hasNextpanoramaRadioStreamer_Detail0;

        /// <summary>
        /// HasNextpanoramaRadioStreamer_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaRadioStreamer_Detail0
        {
            get
            {
				return _hasNextpanoramaRadioStreamer_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaRadioStreamer_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaRadioStreamer_Detail0;

        /// <summary>
        /// HasPreviouspanoramaRadioStreamer_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaRadioStreamer_Detail0
        {
            get
            {
				return _hasPreviouspanoramaRadioStreamer_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaRadioStreamer_Detail0, value);
            }
        }
	    /// <summary>
        /// IsInternetAvailable property.
        /// </summary>		
        public override Visibility IsInternetAvailable
        {
	      get
          {
				return Visibility.Collapsed; 
           }
		}

        /// <summary>
        /// Delegate method for the TextToSpeechRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechRadioStreamer_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentStreamerSchema.Title + " " + CurrentStreamerSchema.Subtitle);
        }
		

        private ICommand _textToSpeechRadioStreamer_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechRadioStreamer_DetailStaticControlCommand
        {
            get { return _textToSpeechRadioStreamer_DetailStaticControlCommand = _textToSpeechRadioStreamer_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechRadioStreamer_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareRadioStreamer_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentStreamerSchema.Title, CurrentStreamerSchema.Subtitle, "", CurrentStreamerSchema.Image);
        }
		

        private ICommand _shareRadioStreamer_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareRadioStreamer_DetailStaticControlCommand
        {
            get { return _shareRadioStreamer_DetailStaticControlCommand = _shareRadioStreamer_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareRadioStreamer_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartRadioStreamer_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IRadioStreamer_DetailViewModel), CreateTileInfoRadioStreamer_DetailStaticControl());
        }
		

        private ICommand _pinToStartRadioStreamer_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartRadioStreamer_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartRadioStreamer_DetailStaticControlCommand
        {
            get { return _pinToStartRadioStreamer_DetailStaticControlCommand = _pinToStartRadioStreamer_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartRadioStreamer_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaRadioStreamer_Detail0 command.
        /// </summary>
        public  void NextpanoramaRadioStreamer_Detail0Delegate() 
        {
			var next =  _radioStreamer_Streamer.Next(CurrentStreamerSchema);

			if(next != null)
				CurrentStreamerSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaRadioStreamer_Detail0;

        /// <summary>
        /// Gets the NextpanoramaRadioStreamer_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaRadioStreamer_Detail0
        {
            get { return _nextpanoramaRadioStreamer_Detail0 = _nextpanoramaRadioStreamer_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaRadioStreamer_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaRadioStreamer_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaRadioStreamer_Detail0Delegate() 
        {
			var prev =  _radioStreamer_Streamer.Previous(CurrentStreamerSchema);

			if(prev != null)
				CurrentStreamerSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaRadioStreamer_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaRadioStreamer_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaRadioStreamer_Detail0
        {
            get { return _previouspanoramaRadioStreamer_Detail0 = _previouspanoramaRadioStreamer_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaRadioStreamer_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaRadioStreamer_Detail0 = _radioStreamer_Streamer.HasPrevious(CurrentStreamerSchema);
			HasNextpanoramaRadioStreamer_Detail0 = _radioStreamer_Streamer.HasNext(CurrentStreamerSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.StreamerSchema)) { return; }
                
                CurrentStreamerSchema = value as Entities.StreamerSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the RadioStreamer_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoRadioStreamer_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentStreamerSchema.Id.ToString(),
                Title = CurrentStreamerSchema.Title,
                BackTitle = CurrentStreamerSchema.Title,
                BackContent = CurrentStreamerSchema.Subtitle,
                Count = 0,
                BackgroundImagePath = CurrentStreamerSchema.Image,
                BackBackgroundImagePath = CurrentStreamerSchema.Image,
                LogoPath = "Logo-d8c5800e-008d-427f-8760-3d6e8ed66cfb.png"
            };
            return tileInfo;
        }
    }
}