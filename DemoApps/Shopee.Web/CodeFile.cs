public class SingletonEarl
{
	private static SingletonEarl? _instance;

	private SingletonEarl() 
	{
		
	}
	public static SingletonEarl Make() 
	{ 
		if (_instance == default(SingletonEarl)) 
		{
			_instance = new SingletonEarl();
		}
		return _instance;
	}


}

public class SingletonEarlTest
{
	[Fact]
	public void Make_should_always_return_same_instance() 
	{ 
		var first = SingletonEarl.Make();
		var second = SingletonEarl.Make();

		Assert.Same(first, second);
	}
}


//thread-safe singleton class
public class SingletonEarlLocked
{
	private readonly static object _elock = new();
	private static SingletonEarlLocked? _instance;

	private SingletonEarlLocked()
	{

	}
	public static SingletonEarlLocked Make()
	{
		lock (_elock)
		{
			if (_instance == default)
			{
				_instance = new SingletonEarlLocked(); 
			}
			return _instance;
		}
	}

}

public class DotNetSingleton
{
	public static DotNetSingleton Instance { get; } = new DotNetSingleton();
	private DotNetSingleton() { }

	// DotNetSingleton.Instance.SomeOperation();
}

public class SingletonEarlTest2
{
	[Fact]
	public void Make_should_always_return_same_instance()
	{
		var first = DotNetSingleton.Instance;
		var second = DotNetSingleton.Instance;

		Assert.Same(first, second);
	}
}