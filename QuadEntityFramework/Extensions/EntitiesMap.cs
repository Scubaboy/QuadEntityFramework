using AutoMapper;
using QuadEntityFramework.Entities;
using QuadModels;

namespace QuadEntityFramework.Extensions
{
    public static class EntitiesMap
    {
        static EntitiesMap()
        {
            Mapper.CreateMap<ActiveQuadEntity, ActiveQuad>()
                .ConstructUsing(x => new ActiveQuad(x.ActiveQuadEntityId));
            
            Mapper.AssertConfigurationIsValid();
        }

        public static ActiveQuad ToModel(this ActiveQuadEntity activeQuad)
        {
            return activeQuad == null
                ? null
                : Mapper.Map<ActiveQuadEntity, ActiveQuad>(activeQuad);
        }
    }
}
