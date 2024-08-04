namespace MongoDBEFCoreDemo
{
    public class MongDbService
    {
        private readonly AppDbContext _context;
        public MongDbService(AppDbContext dbContext) {
            _context = dbContext;
        }

        public void AddCustomer(CustomerDTO customerDto)
        {
            Customer customer = new() { Name = customerDto.Name, Designation = customerDto.Designation };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.OrderByDescending(c => c.Id).Take(20).ToList();
        }
    }
}
