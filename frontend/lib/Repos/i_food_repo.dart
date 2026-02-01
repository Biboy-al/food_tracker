import '../Models/Food.dart';

abstract class IFoodRepo{

  Future<Food> getFood(int id);

  Future<Food> getAllFood();

  bool saveFood(Food f);

}