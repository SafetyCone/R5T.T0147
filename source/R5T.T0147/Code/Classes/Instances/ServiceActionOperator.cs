using System;


namespace R5T.T0147
{
	public class ServiceActionOperator : IServiceActionOperator
	{
		#region Infrastructure

	    public static ServiceActionOperator Instance { get; } = new ServiceActionOperator();

	    private ServiceActionOperator()
	    {
        }

	    #endregion
	}
}