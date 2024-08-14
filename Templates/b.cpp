#include <iostream>
#include <vector>
#include <algorithm>
// 升序
struct Person
{
    int a;
    int b;
    bool operator<(const Person &other) const
    {
        return a < other.a;
    }
} pp[100];

struct T
{
    int c;
    int d;
    bool operator>(const T &other) const
    {
        return c > other.c;
    }
} qq[100];
// 定义结构体
struct Person
{
    std::string name;
    int age;
    double height;

    // 构造函数
    Person(std::string n, int a, double h) : name(n), age(a), height(h) {}
};

// 按照年龄排序的比较函数
bool compareByAge(const Person &p1, const Person &p2)
{
    return p1.age < p2.age; // 按照年龄升序排列
}

int main()
{
    // 创建一个 Person 结构体的向量
    std::vector<Person> people = {
        Person("Alice", 30, 5.5),
        Person("Bob", 25, 5.9),
        Person("Charlie", 35, 5.7)};

    // 输出排序前的向量
    std::cout << "Before sorting:" << std::endl;
    for (const auto &person : people)
    {
        std::cout << person.name << " - Age: " << person.age << ", Height: " << person.height << std::endl;
    }

    // 按照年龄排序
    std::sort(people.begin(), people.end(), compareByAge);

    // 输出排序后的向量
    std::cout << "\nAfter sorting by age:" << std::endl;
    for (const auto &person : people)
    {
        std::cout << person.name << " - Age: " << person.age << ", Height: " << person.height << std::endl;
    }

    return 0;
}
