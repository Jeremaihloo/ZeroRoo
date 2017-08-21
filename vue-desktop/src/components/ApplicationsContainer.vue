<template>
  <div id="applications">
    <app-activity v-for="(item, index) in activities" :activity="item" :key="index"></app-activity>
  </div>
</template>

<script>
import AppActivity from './AppActivity'

export default {
  components: {
    AppActivity
  },
  data() {
    return {
      activities: []
    }
  },
  created() {
    this.$bus.on('activity:open', activity => {
      this.activities.push(activity)
      console.log('activity:open callback', activity)
    })
  }
}
</script>
