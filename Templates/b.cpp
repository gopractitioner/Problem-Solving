#include <iostream>
#include <vector>
#include <algorithm>

int main()
{
    std::vector<int> vec = {1, 3, 3, 5, 7, 9};
    int value = 3;
    auto it = std::lower_bound(vec.begin(), vec.end(), value);
    // upper_bound() returns the first element that is greater than the value
    if (it != vec.end())
    {
        std::cout << "The first element not less than " << value << " is at index "
                  << std::distance(vec.begin(), it)
                  << " with value " << *it << std::endl;
    }
    else
    {
        std::cout << "All elements are smaller than " << value << std::endl;
    }

    return 0;
}
