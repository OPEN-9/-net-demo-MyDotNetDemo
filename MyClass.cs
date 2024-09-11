 class MyClass
    {
        public void ArrayMethod()
        {
            int[] evenNums = new int[5] { 1, 4, 3, 8, 10 };

            string[] cities = new string[4] { "吃饭", "睡觉", "学习", "工作" };

            Console.WriteLine(evenNums[0]);
            Console.WriteLine(cities[0]);
        }

        public void ListMethod()
        {
            // 动态列表
            List<int> list = new List<int> { 3, 6, 9 };

            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            list.Remove(3);

            Console.WriteLine("\n删除元素后列表：");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
        }

        public void DictionaryMethod()
        {
            // 词典
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "paul", 18 },
                { "tom", 20 },
                { "orange", 15 }
            };

            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }

        public void LinqMethod()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //大于 3 的数
            var filteredNumbers = numbers.Where(n => n > 3);
            Console.WriteLine(string.Join(", ", filteredNumbers));

            //排序
            var sortedNumbers = numbers.OrderByDescending(n => n);
            Console.WriteLine(string.Join(", ", sortedNumbers));

            //number.Max()等扩展方法;
        }

        public async Task<List<int>> GetDataAsync()
        {
            await Task.Delay(2000);
            List<int> numbers = new List<int> { 1, 2, 3 };
            return numbers;
        }
    }

