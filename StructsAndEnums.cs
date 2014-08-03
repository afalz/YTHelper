using System;

namespace YTHelper
{
	public enum YTPlayerState {
		Unstarted,
		Ended,
		Playing,
		Paused,
		Buffering,
		Queued,
		Unknown
	}

	public enum YTPlaybackQuality {
		Small,
		Medium,
		Large,
		HD720,
		HD1080,
		HighRes,
		Unknown
	}

	public enum YTPlayerError {
		InvalidParam,
		HTML5Error,
		VideoNotFound,
		NotEmbeddable,
		Unknown
	}
}