﻿namespace AndroidBinderator
{
	public class MavenArtifactModel
	{
		public string MavenGroupId { get; set; }
		public string MavenArtifactId { get; set; }
		public string MavenArtifactVersion { get; set; }
		public string MavenArtifactPackaging { get; set; }

		public string DownloadedArtifact { get; set; }
		public string ProguardFile { get; set; }
	}
}
