<template>
  <div class="messages">
    <!-- With Collapse -->
    <collapse v-for="(item, index) in messages" :key="index" v-model="item.Enabled">
      <alert type="info" :closable="true" @close="item.Enabled = false">
        {{item.Data}}
      </alert>
    </collapse>
  </div>
</template>

<script>
export default {
  data () {
    return {
      messages: []
    }
  },
  mounted () {
    this.$engine.subscribe('ZeroRoo.Docker.Cores.Services.MessageAlert', res => {
      console.log(res)
      res.Enabled = true
      this.messages = Object.assign([res], this.messages)
    })
  }
}
</script>

