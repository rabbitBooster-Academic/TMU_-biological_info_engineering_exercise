public struct DeltaTimeTransferViewModel
{
    public DeltaTimeTransferViewModel(float deltaTime)
    {
        DeltaTime = deltaTime;
    }

    public float DeltaTime { get; }
}