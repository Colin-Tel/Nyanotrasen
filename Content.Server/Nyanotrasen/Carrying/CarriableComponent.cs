namespace Content.Server.Carrying
{
    [RegisterComponent]
    public sealed class CarriableComponent : Component
    {
        /// <summary>
        ///     Number of free hands required
        ///     to carry the entity
        /// </summary>
        [DataField("freeHandsRequired")]
        public int FreeHandsRequired = 2;
    }
}
