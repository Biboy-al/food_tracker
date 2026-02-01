import 'package:frontend/Models/Food.dart';

abstract class IFoodService{
  
  Future<List<dynamic>> fetchAllFood();

  Future<Food> saveFood();
}