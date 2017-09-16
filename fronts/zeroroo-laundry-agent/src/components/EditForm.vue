<template>
  <form class="form-horizontal">
    <dropdown class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">日期</label>
      <div class="col-sm-8">
        <div class="input-group">
          <input class="form-control" type="text" v-model="editData.orderDate">
          <div class="input-group-btn">
            <button class="btn btn-default" type="button" data-role="trigger">
              <i class="glyphicon glyphicon-calendar"></i>
            </button>
          </div>
        </div>
      </div>
      <template slot="dropdown">
        <li>
          <date-picker v-model="editData.orderDate" :week-starts-with="0"></date-picker>
        </li>
      </template>
    </dropdown>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">姓名</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.name" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">品牌</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.brand" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">款式</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.style" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">颜色</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.color" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">尺码</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.size" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">件数</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.count" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">售价</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.sale_price" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">付款状况</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.pay_status" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <dropdown class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">发货日期</label>
      <div class="col-sm-8">
        <div class="input-group">
          <input class="form-control" type="text" v-model="editData.issuance_at">
          <div class="input-group-btn">
            <button class="btn btn-default" type="button" data-role="trigger">
              <i class="glyphicon glyphicon-calendar"></i>
            </button>
          </div>
        </div>
      </div>
      <template slot="dropdown">
        <li>
          <date-picker v-model="editData.issuance_at" :week-starts-with="0"></date-picker>
        </li>
      </template>
    </dropdown>
    <dropdown class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">到货日期</label>
      <div class="col-sm-8">
        <div class="input-group">
          <input class="form-control" type="text" v-model="editData.received_at">
          <div class="input-group-btn">
            <button class="btn btn-default" type="button" data-role="trigger">
              <i class="glyphicon glyphicon-calendar"></i>
            </button>
          </div>
        </div>
      </div>
      <template slot="dropdown">
        <li>
          <date-picker v-model="editData.received_at" :week-starts-with="0"></date-picker>
        </li>
      </template>
    </dropdown>
    <dropdown class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">取走日期</label>
      <div class="col-sm-8">
        <div class="input-group">
          <input class="form-control" type="text" v-model="editData.take_at">
          <div class="input-group-btn">
            <button class="btn btn-default" type="button" data-role="trigger">
              <i class="glyphicon glyphicon-calendar"></i>
            </button>
          </div>
        </div>
      </div>
      <template slot="dropdown">
        <li>
          <date-picker v-model="editData.take_at" :week-starts-with="0"></date-picker>
        </li>
      </template>
    </dropdown>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">收货地址</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.address" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">快递</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.post_type" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">单号</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.post_id" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">备注</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.mark" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">发货人</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.post_person" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
    <div class="form-group">
      <label for="inputtext3" class="col-sm-2 control-label">成本</label>
      <div class="col-sm-8">
        <input type="text" v-model="editData.get_price" class="form-control" id="inputtext3" placeholder="text">
      </div>
    </div>
  </form>
</template>

<script>
export default {
  props: ['data'],
  computed: {
    editData () {
      return this.data
    }
  }
}
</script>

<style>

</style>
