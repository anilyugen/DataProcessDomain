using System;
using System.Collections.Generic;
using System.Text;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public abstract class TespaProjectResearchGroup : ProductBasedProjectResearchGroup<TespaProjectResearchGroupProduct>
    {
        public override ResearchGroupType ResearchGroupType => ResearchGroupType.Tespa;

        public abstract RgTespaScoreCalculationMethod? TespaScoreCalculationMethod { get; }
    }

    /// <summary>
    /// Firmanın toplam raf payının hangi raf payı aralığına uygun olduğu belirlenir ve bu şekilde puanlama yapılır.
    /// </summary>
    public class TespaByTotalRangeProjectResearchGroup : TespaProjectResearchGroup, IHasProjectResearchGroupRanges
    {
        public override RgTespaScoreCalculationMethod? TespaScoreCalculationMethod => RgTespaScoreCalculationMethod.ByTotalRange;

        public List<ProjectResearchGroupRange> Ranges { get; set; }
    }

    /// <summary>
    /// Her bir ürünün raf payının hangi ürün raf payı aralığına uygun olduğu belirlenir ve bu şekilde puanlama yapılır.
    /// </summary>
    public class TespaByProductRangeProjectResearchGroup : TespaProjectResearchGroup
    {
        public override RgTespaScoreCalculationMethod? TespaScoreCalculationMethod => RgTespaScoreCalculationMethod.ByProductRange;
    }

    /// <summary>
    /// Firmanın toplam raf payının, belirlenen hedeflere uygun olup olmadığı belirlenir ve hedefe ulaşma oranı üzerinden puanlama yapılır.
    /// </summary>
    public class TespaByTotalTargetProjectResearchGroup : TespaProjectResearchGroup
    {
        public override RgTespaScoreCalculationMethod? TespaScoreCalculationMethod => RgTespaScoreCalculationMethod.ByTotalTarget;

        public TespaTarget Target { get; set; }
    }

    /// <summary>
    /// Her bir ürünün raf payının, belirlenen ürün hedeflerine uygun olup olmadığı belirlenir ve hedefe ulaşma oranı üzerinden puanlama yapılır.
    /// </summary>
    public class TespaByProductTargetProjectResearchGroup : TespaProjectResearchGroup
    {
        public override RgTespaScoreCalculationMethod? TespaScoreCalculationMethod => RgTespaScoreCalculationMethod.ByProductTarget;
    }
}