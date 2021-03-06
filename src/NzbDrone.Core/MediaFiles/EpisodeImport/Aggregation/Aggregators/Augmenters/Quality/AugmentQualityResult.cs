using NzbDrone.Core.Qualities;

namespace NzbDrone.Core.MediaFiles.EpisodeImport.Aggregation.Aggregators.Augmenters.Quality
{
    public class AugmentQualityResult
    {
        public QualitySource Source { get; set; }
        public Confidence SourceConfidence { get; set; }
        public int Resolution { get; set; }
        public Confidence ResolutionConfidence { get; set; }
        public Revision Revision { get; set; }

        public AugmentQualityResult(QualitySource source,
                                    Confidence sourceConfidence,
                                    int resolution,
                                    Confidence resolutionConfidence,
                                    Revision revision)
        {
            Source = source;
            SourceConfidence = sourceConfidence;
            Resolution = resolution;
            ResolutionConfidence = resolutionConfidence;
            Revision = revision;
        }

        public static AugmentQualityResult SourceOnly(QualitySource source, Confidence sourceConfidence)
        {
            return new AugmentQualityResult(source, sourceConfidence, 0, Confidence.Default, null);
        }

        public static AugmentQualityResult ResolutionOnly(int resolution, Confidence resolutionConfidence)
        {
            return new AugmentQualityResult(QualitySource.Unknown, Confidence.Default, resolution, resolutionConfidence, null);
        }
    }
}
